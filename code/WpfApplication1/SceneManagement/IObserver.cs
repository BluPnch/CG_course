using System.Windows.Media.Media3D;


namespace WpfApplication1
{
    public interface ISunObserver
    {
        void UpdateSunPosition(Vector3D sunPosition);
    }
}