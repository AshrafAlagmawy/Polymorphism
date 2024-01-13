using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Polymorphism Has Two Types 
    * Runtime Polymorphism / Overriding / Dynamic Polymorphism
    * Compiletime Polymorphism / Overloading / Static Polymorphism

 * Overriding vs Overloading
 
    * Overriding => Two methods with the same name and the same signature
    * Overloading => Two methods with the same name but different signature
        * Different Signature such as return datatype or number of parameters or types of parameters

*/

namespace Polymorphism
{
    internal abstract class Employee
    {
        public abstract decimal GetSalary();
    }
}
 