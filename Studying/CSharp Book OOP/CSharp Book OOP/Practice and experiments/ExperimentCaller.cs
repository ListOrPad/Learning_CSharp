internal class ExperimentCaller
{
    public void CallExp1()
    {

        //exp 5 finally, classes

        Score best = new Score();

        best.name = "Evi";
        best.points = 4444;
        best.level = 4;

        if (best.EarnedStar())
            Console.WriteLine($"{best.name}, You've earned a star!");
    }

    public void CallExp2()
    {
        Animal animal = new Animal();
        Pig pig = new Pig();
        Dog dog = new Dog();

        animal.Sound();
        pig.Sound();
        dog.Sound();
    }
    public void CallExp3()
    {
        Exp3 exp3 = new Exp3();
        exp3.Exp3Caller();
    }

    public void CallExp4()
    {
        Exp4 exp4 = new Exp4();
        exp4.Exp4Caller();
    }
    public void CallExp5()
    {
        Exp5 exp5 = new Exp5();
        exp5.Exp5Call();
    }
    //public void CallExp6()
    //{
    //    Exp6 exp6 = new Exp6();
    //    exp6.Exp6Call();
    //}
    public void CallExp7()
    {
        Exp7 exp7 = new Exp7();
        exp7.Exp7Call();
    }
    public void CallExp8()
    {
        DateForAlex exp8 = new DateForAlex();
        exp8.Exp8Caller();
    }
}