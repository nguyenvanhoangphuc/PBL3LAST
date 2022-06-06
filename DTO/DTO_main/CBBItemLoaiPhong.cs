namespace QuanLyPhongTroLinQ.DTO
{
    public class CBBItemLoaiPhong
    {
        public string ID { get; set; }
        public string TenLoaiPhong { get; set; }
        public override string ToString()
        {
            return TenLoaiPhong;
        }

    }
}
