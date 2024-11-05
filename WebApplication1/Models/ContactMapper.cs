namespace WebApplication1.Models;

public class ContactMapper
{
    public static ContactModel FromEntity(ContactEntity entity)
    {
        return new ContactModel()
        {
            Id = entity.Id,
            FirstName = entity.FirstName,
            LastName = entity.LastName,
            BirthDate = entity.BirthDate,
            PhoneNumber = entity.PhoneNumber,
            Email = entity.Email,
            Category = entity.Category
        };
    }

    public static ContactEntity ToEntity(ContactModel model)
    {
        return new ContactEntity()
        {
            Id = model.Id,
            FirstName = model.FirstName,
            LastName = model.LastName,
            BirthDate = model.BirthDate,
            PhoneNumber = model.PhoneNumber,
            Email = model.Email,
            Category = model.Category
        };
    }
}