using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePractice
{
    public interface IOne
    {
        void One();
    }
    public interface ITwo
    {
        void Two();
    }
    public interface IThree:IOne
    {
        void Three();
    }
    public interface IFour:ITwo
    {
        void Four();
    }
    public interface IFive:IThree
    {
        void Five();
    }
    public interface ISix : IFour
    {
        void Six();
    }
}
