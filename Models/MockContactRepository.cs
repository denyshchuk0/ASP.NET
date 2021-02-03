using System.Collections.Generic;
using System.Linq;

namespace TestProject.Models
{
    public class MockContactRepository : IContactRepository
    {

        private List<Contact> _contactList;
        public MockContactRepository()
        {
            _contactList = new List<Contact>() {
            new Contact()
                { Id = 1, Name = "Camilla Tery", Position = "Software Engeneer at SoftServe", Address = "Rivne, Soborna street", Avatar = "avatar3.png", NickName="CamT", PhoneNumber="+38-099-784-51-11", Email="cam@gmail.com" },
            new Contact()
                { Id = 2, Name = "Linus Torvalds", Position = "Linux kernel CTO", Address = "San Francisco, Banderu street", Avatar = "", NickName="LT", PhoneNumber="+38-068-784-51-12", Email="linus@kernel.com" },
            };
        }
        public Contact GetContact(int id)
        {
            return _contactList.FirstOrDefault(e => e.Id == id);
        }
        public void AddContact(Contact model)
        {
            model.Id = _contactList.Count() + 1;
            _contactList.Add(model);
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return _contactList;
        }
    }
}
