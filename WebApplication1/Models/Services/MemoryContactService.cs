namespace WebApplication1.Models.Services;

public class MemoryContactService:IContactService
{
    private Dictionary<int, ContactModel> _contacts = new Dictionary<int, ContactModel>()
    {
        {
            1,
            new()
            {
                Id = 1, Email = "ascfsd@gmail.com", FirstName = "Olaf", LastName = "Ciuła", Category = Category.Family,
                BirthDate = new DateTime(1970, 10, 10), PhoneNumber = "333 333 333"
            }
        },
        {
            2,
            new()
            {
                Id = 2, Email = "arfsdd@gmail.com", FirstName = "Ola", LastName = "rresgd",
                BirthDate = new DateTime(1970, 10, 10), PhoneNumber = "333 333 333"
            }
        }
    };
    private int currentID = 3;
    public void Add(ContactModel model)
    {
        model.Id = ++currentID;
        _contacts.Add(model.Id, model);
    }

    public void Update(ContactModel contact)
    {
        if (_contacts.ContainsKey(contact.Id))
        {
            _contacts[contact.Id] = contact;
        }
    }

    public void Delete(int id)
    {
        _contacts.Remove(id);
    }

    public List<ContactModel> GetAll()
    {
        return _contacts.Values.ToList();
    }

    public ContactModel? GetById(int id)
    {
        return _contacts[id];
    }

    public List<OrganizationEntity> findAllOrganizations()
    {
        throw new NotImplementedException();
    }
}