namespace QuanLyPhongTroLinQ.DTO
{
    public class CBBItem
    {
        public string ID { get; set; }
        public string TenLoaiPhong { get; set; }
        public override string ToString()
        {
            return TenLoaiPhong;
        }
    }
}
