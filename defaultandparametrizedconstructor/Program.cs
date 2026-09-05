using System;
using defaultandparametrizedconstructor;

class program {
    static void Main(string[] args)
    {


        Defaultconstructor s = new Defaultconstructor();
        s.Display();
        ParameterizedConstructor p = new ParameterizedConstructor(101, "Ram");
        p.Display();

    }
}



