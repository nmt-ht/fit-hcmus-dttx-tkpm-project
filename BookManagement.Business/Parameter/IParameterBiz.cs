using BookManagement.Models;

namespace BookManagement.Business
{
  public  interface IParameterBiz
    {
        IEnumerable<Parameter> GetParameters();
        bool AddNewParameter(Parameter Parameter);
        bool DeleteParameter(Guid id);
        bool UpdateParameter(Parameter Parameter);
    }
}
