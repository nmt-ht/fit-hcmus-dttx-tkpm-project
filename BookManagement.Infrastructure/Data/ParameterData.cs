using BookManagement.Infrastructure.DataAccess.DbAccess;
using BookManagement.Models;

namespace BookManagement.Infrastructure.Data;

public class ParameterData: IParameterData
{
    public readonly ISqlDataAccess _db;
    public ParameterData(ISqlDataAccess db) => _db = db;
    public IEnumerable<Parameter> GetParameters()
    {
        return _db.LoadData<Parameter, dynamic>("spr_Parameter_GetAllParameter", new { });
    }
    public IEnumerable<Parameter> GetParameterById(Guid id)
    {
        return _db.LoadData<Parameter, dynamic>("spr_Parameter_GetParameterById", new { Id = id });
    }
    public bool InsertParameter(Parameter parameter)
    {
        var result = false;
        try
        {
            _db.SaveData("spr_Parameter_InsertData",
           new
           {
               parameter.Name,
               parameter.Value,
           });
            result = true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return result;
    }
    public bool UpdateParameter(Parameter parameter)
    {
        var result = false;
        try
        {
            _db.SaveData("spr_Parameter_UpdateData",
           new
           {
               Name = parameter.Name,
               Value = parameter.Value,
               Id = parameter.Id
           });
            result = true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return result;
    }
    public bool DeleteParameter(Guid id)
    {
        var result = false;
        try
        {
            _db.SaveData("spr_Parameter_DeleteData", new { Id = id });
            result = true;
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

        return result;
    }
}
