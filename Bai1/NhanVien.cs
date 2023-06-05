
using Bai1;

class NhanVien : CanBo
{
    public string Job { get; set; }
    public NhanVien(string Name, Gender Gender, int Age, string Job) : base(Name, Gender, Age)
    {
        this.Job = Job;
    }
    public override string ToString()
    {
        return $@"Tên: {Name}  Giới tính {Gender.ToString()}  Tuổi: {Age}  Công việc:{Job}";
    }
}