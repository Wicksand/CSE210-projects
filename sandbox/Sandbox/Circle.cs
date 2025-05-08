class Circle
{
    private double _radius;

    public void SetRadius(double radius){
        if(radius < 0){
           Console.WriteLine("Error");
           return;
        }
            _radius = radius;

    }
    public double GetRadius(double radius){
        return _radius;
    }
    public double GetArea(){
        return Math.PI * _radius *_radius;
    }

}