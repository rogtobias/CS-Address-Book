using System.Collections.Generic;

namespace AddressBookProject.Objects
{
  public class AddressBook
  {
    private string _name;
    private string _address;
    private string _city;
    private string _state;
    private int _zipCode;
    private int _id;
    private static List<AddressBook> _instances = new List<AddressBook> {};

    public AddressBook(string name, string addressNumber, string city, string state, int zipCode)
    {
      _name = name;
      _address = address;
      _city = city;
      _state = state;
      _zipCode = zipCode
      _id = _instances.Count;
      _instances.Add(this);
    }

    public string GetName()
    {
      return _name;
    }
    public void SetName(string name)
    {
      _name = name;
    }

    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string address)
    {
      _address = address;
    }

    public string GetCity()
    {
      return _city;
    }
    public void SetCity(string city)
    {
      _city = city;
    }

    public string GetState()
    {
      return _state;
    }
    public void SetState(string state)
    {
      _state = state;
    }

    public int GetZipCode()
    {
      return _zipCode;
    }
    public void SetZipCode(int zipCode)
    {
      _zipCode = zipCode;
    }

    public static List<AddressBook> GetAll()
    {
      return _instances;
    }
    public void Save()
    {
      _instances.Add(this);
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static AddressBook SearchAddressBooks(int searchId)
    {
      return _instances[searchId];
    }
    public void Remove()
    {
      _instances.Remove(this);
    }
  }
}
