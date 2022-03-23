namespace Tuan4_web.Models
{
    public abstract class GiohangBase
    {
        public abstract int masach { get; set; }
        public abstract string tensach { get; set; }
        public abstract string hinh { get; set; }
        public abstract double giaban { get; set; }
        public abstract int iSoluong { get; set; }
        public abstract double dThanhtien { get; }
    }
}