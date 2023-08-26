using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp1
{
    public partial class Form1 : Form
    {
        public class Question
        {
            public string Text { get; set; } //задание
            public string[] Options { get; set; } //варианты ответов
            public int CorrectOptionIndex { get; set; } //заложен правильный ответ по индексу
        }
        private int progress = 0; //progressbar по выполнению теста
        private Question[] questions; //
        private int currentQuestionIndex;

        // Задаем подсчет баллов и его сохранение за пределами метода
        private int point = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeQuestions();
            // Начинаем с первого вопроса
            currentQuestionIndex = 0;

            // Выводим первый вопрос на экран
            DisplayQuestion();

        }

        private void InitializeQuestions()
        {
            // Создаем объекты Question для каждого вопроса
            questions = new Question[]
            {
            new Question
            {
                Text = "Вопрос 1:\n Какое вещество является химическим элементом с символом \"H\"?",
                Options = new string[] { "Гелий", "Гидроген", "Германий", "Гафний" },
                CorrectOptionIndex = 1
            },
            new Question
            {
                Text = "Вопрос 2:\n Какая планета Солнечной системы известна своими кольцами?",
                Options = new string[] { "Земля", "Венера", "Сатурн", "Марс" },
                CorrectOptionIndex = 2
            },
            new Question
            {
                Text = "Вопрос 3:\n Сколько сторон у прямоугольника?",
                Options = new string[] { "3", "4", "5", "6" },
                CorrectOptionIndex = 0
            },
            new Question
            {
                Text = "Вопрос 4:\n Какое из чисел является простым?",
                Options = new string[] { "15", "5", "18", "100" },
                CorrectOptionIndex = 1
            },
            new Question
            {
                Text = "Вопрос 5:\n Какой газ необходим растениям для фотосинтеза?",
                Options = new string[] { "Кислород", "Азот", "Углекислый газ", "Водород" },
                CorrectOptionIndex = 2
            },
            new Question
            {
                Text = "Вопрос 6:\n Какое животное известно своим хоботом?",
                Options = new string[] { "Носорог", "Слон", "Жираф", "Тигр" },
                CorrectOptionIndex = 1
            },
            new Question
            {
                Text = "Вопрос 7:\n Сколько зубов у взрослого человека обычно?",
                Options = new string[] { "32", "28", "20", "36" },
                CorrectOptionIndex = 0
            },
            new Question
            {
                Text = "Вопрос 8:\n Кто написал произведение \"Война и мир\"?",
                Options = new string[] { "Лев Толстой", "Федор Достоевский", "Александр Пушкин", "Николай Гоголь" },
                CorrectOptionIndex = 0
            },
            new Question
            {
                Text = "Вопрос 9:\n Какой из этих планет находится ближе всего к Солнцу?",
                Options = new string[] { "Марс", "Юпитер", "Венера", "Уран" },
                CorrectOptionIndex = 2
            },
            new Question
            {
                Text = "Вопрос 10:\n Какая столица Франции?",
                Options = new string[] { "Белин", "Лондон", "Рим", "Париж" },
                CorrectOptionIndex = 3
            },
            new Question
            {
                Text = "Вопрос 11:\n Какое из следующих слов является глаголом?",
                Options = new string[] { "Стол", "Погода", "Бежать", "Дом" },
                CorrectOptionIndex = 2
            },
            new Question
            {
                Text = "Вопрос 12:\n Как называется наибольшее океанское животное?",
                Options = new string[] { "Синий кит", "Акула", "Медуза", "Дельфин" },
                CorrectOptionIndex = 0
            },
            new Question
            {
                Text = "Вопрос 13:\n Какой цвет получится при смешении синего и желтого?",
                Options = new string[] { "Красный", "Синий", "Зеленый", "Лиловый" },
                CorrectOptionIndex = 2
            },
            new Question
            {
                Text = "Вопрос 14:\n Какое из следующих слов является существительным?",
                Options = new string[] { "Прыгать", "Комод", "Плыть", "Прекрасный" },
                CorrectOptionIndex = 1
            },
            new Question
            {
                Text = "Вопрос 15:\n Какая из этих планет не имеет своих естественных спутников (лун)?",
                Options = new string[] { "Земля", "Марс", "Юпитер", "Венера" },
                CorrectOptionIndex = 1
            }
            };
        }
        private void DisplayQuestion()
        {
            // Получаем текущий вопрос из массива
            Question currentQuestion = questions[currentQuestionIndex];

            // Выводим текст вопроса
            labelQuestion.Text = currentQuestion.Text; //элементу присваиватся объект класса далее указывается какое после конкретно используется

            // Выводим варианты ответов на RadioButton
            radioButtonOption1.Text = currentQuestion.Options[0]; //к элементу приваиватся значения объекта класс 
            radioButtonOption2.Text = currentQuestion.Options[1];
            radioButtonOption3.Text = currentQuestion.Options[2];
            radioButtonOption4.Text = currentQuestion.Options[3];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            // Проверяем, был ли выбран правильный ответ
            Question currentQuestion = questions[currentQuestionIndex];
            bool isCorrect = false;

            if (radioButtonOption1.Checked && currentQuestion.CorrectOptionIndex == 0)
                isCorrect = true;
            else if (radioButtonOption2.Checked && currentQuestion.CorrectOptionIndex == 1)
                isCorrect = true;
            else if (radioButtonOption3.Checked && currentQuestion.CorrectOptionIndex == 2)
                isCorrect = true;
            else if (radioButtonOption4.Checked && currentQuestion.CorrectOptionIndex == 3)
                isCorrect = true;


            // Проверяем, был ли выбран хотя бы один ответ
            bool anyOptionSelected = radioButtonOption1.Checked || radioButtonOption2.Checked ||
                                     radioButtonOption3.Checked || radioButtonOption4.Checked;

            if (!anyOptionSelected)
            {
                MessageBox.Show("Выберите ответ перед тем, как продолжить.");
                return; // Выходим из метода, чтобы не проверять правильность ответа и не переходить к следующему вопросу
            }

            // Выводим сообщение о результате
            if (isCorrect)
            {
                point++;
                pointplus.Text = $"БАЛЛ: {point}";
            }
            else
                pointplus.Text = $"БАЛЛ: {point}";

            // Переходим к следующему вопросу или завершаем тестирование
            if (currentQuestionIndex < questions.Length - 1)
            {
                currentQuestionIndex++;
                DisplayQuestion();
            }
            else
            {
                MessageBox.Show($" Вы набрали {point} баллов!\n Тестирование завершено!");
                Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
