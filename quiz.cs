public class NullQuestionException : Exception
{
    public NullQuestionException() : base("Вопрос не может быть пустым!") { }
}
public class NullAnswerException : Exception
{
    public NullAnswerException() : base("Ответ не может быть пустым!") { }
}
public class AnswerOutOfRange : Exception
{
    public AnswerOutOfRange() : base("Ответ должен варьироваться от 0 до 3") { }
}

class Aditional
{
    public static bool IsEmpty(string str)
    {
        if (str == null || str == "")
        {
            return true;
        }
        return false;

    }
}

public class Answer
{
    public string answer1;
    public string answer2;
    public string answer3;
    public string answer4;
    public int rightAnswer;

    public Answer(string Answer1, string Answer2, string Answer3, string Answer4, int RightAnswer)
    {
        answer1 = Answer1;
        answer2 = Answer2;
        answer3 = Answer3;
        answer4 = Answer4;
        rightAnswer = RightAnswer;
    }
    public string getAnswer(int num)
    {
        if (num == 0)
        {
            return answer1;
        }
        if (num == 1)
        {
            return answer2;
        }
        if (num == 2)
        {
            return answer3;
        }
        return answer4;
    }
}

public class Quiz
{
    private List<String> questions = new List<String>();
    private List<Answer> answers = new List<Answer>();
    private int points = 0;

    public void addQuestion(string question, string answer1, string answer2, string answer3, string answer4, int rightAnswer)
    {
        if (Aditional.IsEmpty(question))
        {
            throw new NullQuestionException();
        }
        questions.Add(question);
        answers.Add(new Answer(answer1, answer2, answer3, answer4, rightAnswer));
    }

    public int getPoints()
    {
        return points;
    }

    public void tryToAnswer(int numOfAnswers, int chooseOfPlayer)
    {
        if (Aditional.IsEmpty(chooseOfPlayer.ToString()))
        {
            throw new NullAnswerException();
        }
        if (chooseOfPlayer > 3 || chooseOfPlayer < 0)
        {
            throw new AnswerOutOfRange();
        }
        if (answers[numOfAnswers].rightAnswer == chooseOfPlayer)
        {
            points++;
        }

    }
    public void startQuiz()
    {
        Console.WriteLine("Это небольшой квиз. Результаты вы узнаете по окончанию игры. \n За каждый правильный ответ даёться 1 балл");
        for (int i = 0; i < questions.Count; i++)
        {
            Console.WriteLine(questions[i]);
            Console.WriteLine("Варианты: \n");
            for (int j = 0; j < 4; j++)
            {
                Console.WriteLine(j.ToString() + ". " + answers[i].getAnswer(j));
            }
            Console.WriteLine("Введите ответ (от 0 до 3)");
            tryToAnswer(i, Convert.ToInt32(Console.ReadLine()));
        }
        Console.WriteLine("Ваши итоговые очки: " + points);
    }

}