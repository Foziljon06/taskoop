namespace Cars.Classes
{
    class Car
{
    private string _model;
    private int _year;
    private decimal _price;
    private decimal _speed;

    public Car(string model, int year, decimal price, decimal speed)
    {
        _model = model;
        _year = year;
        _price = price;
        _speed = speed;
    }

    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }


    public int Year
    {
        get { return _year; }
        set { _year = value; }
    }


    public decimal Price
    {
        get { return _price; }
        set { _price = value; }
    }

    public decimal Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }
    public string GetCarInfo()
    {
        return $"Model: {_model}, Year: {_year}, Price: ${_price:F2}, Speed: {_speed} km/h";
    }

 
    public decimal CalculateDepreciation(int years)
    {
        return _price * (decimal)Math.Pow(0.9, years);
    }
}
}