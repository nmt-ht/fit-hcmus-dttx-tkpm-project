using BookManagement.Infrastructure.Data;
using BookManagement.Models;

namespace BookManagement.Business;
public class ParameterBiz : IParameterBiz
{
    private readonly IParameterData _parameterData;

    public ParameterBiz(IParameterData parameterData)
    {
        _parameterData = parameterData;
    }

    public bool AddNewParameter(Parameter parameter)
    {
        return _parameterData.InsertParameter(parameter);
    }

    public bool DeleteParameter(Guid id)
    {
        return _parameterData.DeleteParameter(id);
    }

    public IEnumerable<Parameter> GetParameter()
    {
        return _parameterData.GetParameter();
    }

    public bool UpdateParameter(Parameter parameter)
    {
        return _parameterData.UpdateParameter(parameter);
    }

    IEnumerable<Parameter> IParameterBiz.GetParameter()
    {
        throw new NotImplementedException();
    }
}

