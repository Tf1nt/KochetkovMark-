

using System.Security.Cryptography.X509Certificates;

List<String> questions = new List<String>();
List<Answer> answers = new List<Answer>();

questions.Add("Сколько спал студент Марк Кочетков?");
answers.Add(new Answer("спал пока моргал","Не спал","9 часов","24 часа", 1));

questions.Add("Сколько месяцев в году");
answers.Add(new Answer("Да", "Нет", "Наверное", "12", 3));

questions.Add("Что такое while?");
answers.Add(new Answer("Незнаю", "Цикл", "функция", "Я по жизни", 1));

Quiz newQuiz = new Quiz();

for (int i = 0; i < questions.Count; i++)
{
    newQuiz.addQuestion(questions[i], answers[i].answer1, answers[i].answer2, answers[i].answer3, answers[i].answer4, answers[i].rightAnswer);
}

newQuiz.startQuiz();