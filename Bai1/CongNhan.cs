
using Bai1;

class  CongNhan : CanBo
{
    public int Rank { get; set; }
    public   CongNhan(string Name, Gender Gender, int Age, int Rank) : base(Name, Gender, Age)
    {
        this.Rank = Rank;
    }
    public override string ToString()
    {
        return $@"Tên: {Name}  Giới tính {Gender}  Tuổi: {Age}  Bậc: {Rank}";
    }
}