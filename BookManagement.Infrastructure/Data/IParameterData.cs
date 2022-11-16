using BookManagement.Models;

namespace BookManagement.Infrastructure.DataAccess.Data;
public interface IParameterData
{
    bool DeleteParameter(Guid id);
    IEnumerable<Parameter> GetParameterById(Guid id);
    IEnumerable<Parameter> GetParameters();
    bool InsertParameter(Parameter parameter);
    bool UpdateParameter(Parameter parameter);

}
