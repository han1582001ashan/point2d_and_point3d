public class Point3D : Point2D{
    private float z=0.0f;
    public Point3D(){

    }
    public Point3D(float x, float y, float z):base(x,y){
        this.z=z;
    }
    public float getZ()
    {
        return this.z;
    }
    public void setZ(float z)
    {
        this.z = z;
    }
    public void setXYZ(float x, float y, float z)
    {
        this.x = x;
        this.y = y;
        this.z=z;
    }
    public float[] getXYZ()
    {
        return [this.x, this.y, this.z];
    }
     public override string ToString(){
        return "XY: [{"+this.x+"};{"+this.y+"};{"+this.z+"}]" ;
    }
}