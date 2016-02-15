//Друзья, слезно прошу не копипиздить код. Хотя бы не полностью. Создайте свой проект и сделайте по своему. Данный код чисто для ознакомления.
//Так же прошу не использовать мои комментарии, которые я писал для ВАС, будте людьми, всеж мы люди.
using System;
using System.Linq;
using System.Windows.Forms;

namespace BinarySearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для перестановки элементов местами.
        /// </summary>
        /// <param name="a">Первый элемент</param>
        /// <param name="b">Второй элемент</param>
        public static void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// Метод сортировки массива методом Шейкера.
        /// </summary>
        /// <param name="mass">Массив</param>
        public static void ShakeSort(int[] mass)
        {
            //temp должен быть равен чему-либо. Можете попробовать не инициализировать, если хотите.
            var temp = 0;
            //Левая граница массива
            var left = 0;
            //Правая граница массива
            var right = mass.Length - 1;
            while (left < right)
            {
                for (var i = left; i < right; i++)
                {
                    //continue означает то, что мы будет игнорировать последующие строчки при значении true в if.
                    if (mass[i] < mass[i + 1]) continue;
                    //ref нужен для того, чтобы значения, которые поменяются местами в методе Swap, вернулись в программу измененными. 
                    //Можете попробовать без него, только в самом методе тоже уберите ref.
                    Swap(ref mass[i], ref mass[i + 1]);
                    //Запоминаем позицию элемента
                    temp = i;
                }
                //Сокращаем границы массива
                right = temp;

                //Если левая часть станет больше или равна правой, тогда выходим из цикла.
                if (left >= right) break;

                //Почти идентичное повторение первого цикла.
                for (var i = right; i > left; i--)
                {
                    if (mass[i - 1] < mass[i]) continue;
                    Swap(ref mass[i], ref mass[i - 1]);
                    temp = i;
                }
                left = temp;
            }
        }

        /// <summary>
        /// Метод для заполнения массива случайными элементами в выбранном диапазоне.
        /// </summary>
        /// <param name="n">Размерность массива</param>
        /// <param name="mass">Сам массив</param>
        /// <param name="left">Левая граница массива</param>
        /// <param name="right">Правая граница массива</param>
        public static void CreateMass(int n, out int[] mass, int left, int right)
        {
            var rnd = new Random();
            var massLocal = new int[n];
            //Просто поэлементно заполняем массив.
            for (var i = 0; i < massLocal.Length; i++)
            {
                massLocal[i] = rnd.Next(left, right + 1);
            }
            //Поскольку массив мы передавали с параметром ref, то его мы получим на выходе, присвоим ему значение локального массива.
            mass = massLocal;
        }

        /// <summary>
        /// Метод бинарного поиска элемента в массиве.
        /// </summary>
        /// <param name="mass">Массив</param>
        /// <param name="descendingOrder">Переменная, позволяющая выбрать левую или правую часть массива для поиска</param>
        /// <param name="key">Искомое число</param>
        /// <param name="left">Левая граница массива</param>
        /// <param name="right">Правая граница массива</param>
        /// <returns>Порядковый номер элемента</returns>
        public static int BinarySearch_Rec(int[] mass, bool descendingOrder, int key, int left, int right)
        {
            //Запоминаем центр массива
            var mid = left + (right - left)/2;

            //Если мы сократили границы до невозможного
            if (left >= right)
            {
                return -(1 + left);
            }

            //Если левый элемент - искомое число
            if (mass[left] == key)
                return left;

            //Если центральный элемент - искомое число, то мы идем в рекурсию, то есть запускаем метод в методе.
            //Если интересно, то можете почитать про рекурсии, это полезно.
            if (mass[mid] == key)
                return mid == left + 1 ? mid : BinarySearch_Rec(mass, descendingOrder, key, left, mid + 1);

            //Ребят, честно? Использование флага descendingOrder - читерство, которое я даже объяснить не могу нормально.
            //Его суть в том, что он помогает выбрать нужную половину массива для поиска элемента.
            //Дело в том, что все сводится к XOR'у, знания, приобретенные из дискретной математики помогают в этом вопросе.
            //Почитайте про XOR, он не такой сложный.
            if ((mass[mid] > key) ^ descendingOrder)
                return BinarySearch_Rec(mass, descendingOrder, key, left, mid);
            else
                return BinarySearch_Rec(mass, descendingOrder, key, mid + 1, right);
        }


        /// <summary>
        /// Обертка для рекурсивной функции. Просто так удобно.
        /// </summary>
        /// <param name="mass">Массив</param>
        /// <param name="key">Искомое число</param>
        /// <returns></returns>
        public static int BinarySearch_Rec_Wrapper(int[] mass, int key)
        {
            if (mass.Length == 0)
            {
                return -1;
            }

            //descendingOrder - переменная bool'евого типа. mass[0] > mass[mass.Length - 1] может быть как true так и false. 
            //Переменным типа bool можно присваивать то, что мы обычно пишем в if.
            var descendingOrder = mass[0] > mass[mass.Length - 1];
            return BinarySearch_Rec(mass, descendingOrder, key, 0, mass.Length);
        }

        /// <summary>
        /// Действия при нажатии на волшебную кнопку "Найти элемент".
        /// </summary>
        private void search_Click(object sender, EventArgs e)
        {
            //try/cath нужен для того, чтобы не делать кучу условий для ввода. 
            //Эта штучка позволяет не крашнуться программе, а просто вывести сообщение об ошибке и продолжить работу.
            //Можете попробовать без него, прога зависнет.
            try
            {
                //Кол-во элементов массива.
                var a = track.Value;

                //Число, которое нужно найти.
                var b = int.Parse(key.Text);

                //Границы для рандома.
                var left = int.Parse(interval_rnd_left.Text);
                var right = int.Parse(interval_rnd_right.Text);

                //Вывод ошибки при неправильных данных. В этом случае мы пойдем сразу в catch с тем текстом, который находится в скобочках
                if (left > right)
                    throw new Exception("Левая граница не может быть больше правой. Введите данные заного.");
                if ((b > right) || (b < left))
                    //Знак $ заменяет String.Format. Короче говоря, мы можем внутри кавычек писать переменные в фигурных скобках
                    //и они будут красивенько так отображаться
                    throw new Exception($"Искомое число должно находиться в пределах [{left};{right}]. Попробуйте заного.");

                //Создаем массивчик пустой, а потом закидываем его в метод CreateMass
                int[] mass;
                //"Раньше ты использовал ref, почему теперь out?" Все очень просто: 
                //ref если переменная имела какое-либо значение до входа в метод, out если не имела.
                CreateMass(a, out mass, left, right);

                //Сортируем массив методом Земляного Трясителя (Дотеры поймут... Наверное)
                ShakeSort(mass);
                
                //Чисто вывод отсортированного массива. Вы можете скопировать строку 112 в строку 106 и посмотреть
                //Сначала на неотсортированный массив, а потом на отсортированный.
                MessageBox.Show(mass.Aggregate("", (current, t) => current + $"{t}  "), @"Отсортированный массив", 
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                

                //Находим нужный элемент с помощью бинарного поиска, то есть путем деления
                //одномерного массива на 2 части до того момента, пока не будет найден элемент,
                //ну или пока мы не сократим массив до размера одного элемента, который не равен искомому.
                var result = BinarySearch_Rec_Wrapper(mass, b) + 1;
                //Тут я использовал тернарную операцию вида (bool) ? true : false
                //Которая расшифровывается так
                //if (bool)
                //  {
                //      true;
                //  }
                //else
                //  {
                //      false;
                //  }
                //Тернарная операция возвращает значение, на которое попадает. То есть вернет true если bool=true и наоборот.
                //Так же она может возвращать числа, строки и все-все-все. ВАМ советую самостоятельно поменять на if else. 
                //И лучше не используйте MessageBox, а выводите куда-нибудь в label или textBox.
                MessageBox.Show(
                    result > 0 //bool
                        ? $"Порядковый номер найденного элемента в отсортированном массиве: {result}." //true
                        : @"Такого числа нет в созданном массиве.", //false
                    @"Результат поиска", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //Вывод ошибки при неправильных данных
                MessageBox.Show(ex.Message, @"AHTUNG!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        /// <summary>
        /// Движется ползунок - меняется текст под ним.
        /// </summary>
        private void track_Scroll(object sender, EventArgs e)
        {
            label2.Text = track.Value.ToString();
        }
    }
}
