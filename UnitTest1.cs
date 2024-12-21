

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void PointsAddDoingCorrect()
        {
            Quiz newQuiz = new Quiz();
            newQuiz.addQuestion("это тестовый вопрос", "Тестовый ответ", "Тестовый ответ", "Тестовый ответ", "Тестовый ответ", 3);
            newQuiz.tryToAnswer(0, 3);
            Assert.Equal(1, newQuiz.getPoints());
        }
        [Fact]

        public void FoundAnswerOutOfRange()
        {
            Quiz newQuiz = new Quiz();
            newQuiz.addQuestion("это тестовый вопрос", "Тестовый ответ", "Тестовый ответ", "Тестовый ответ", "Тестовый ответ", 3);

            Assert.Throws<AnswerOutOfRange>(() => newQuiz.tryToAnswer(0, 6));

        }
        [Fact]
        public void CreatedQuestionReallyExist()
        {
            Quiz newQuiz = new Quiz();
            string question = "это тестовый вопрос";
            string answer1 = "Тестовый ответ";
            string answer2 = "Тестовый ответ";
            string answer3 = "Тестовый ответ";
            string answer4 = "Тестовый ответ";
            int realAnswer = 3;
            newQuiz.addQuestion(question, answer1, answer2, answer3, answer4, realAnswer);

            Assert.Equal("это тестовый вопрос", question);
            Assert.Equal("Тестовый ответ", answer1);
            Assert.Equal("Тестовый ответ", answer2);
            Assert.Equal("Тестовый ответ", answer3);
            Assert.Equal("Тестовый ответ", answer4);
            Assert.Equal(3, realAnswer);
        }
    }
}
