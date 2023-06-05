
using Bai1;

class KySu : CanBo
{
    public string Specilization { get; set; }
    public KySu(string Name, Gender Gender, int Age, string Specializtion) : base(Name, Gender, Age)
    {
        this.Specilization = Specializtion;
    }
    public override string ToString()
    {
        return $@"Tên: {Name}  Giới tính {Gender.ToString()}  Tuổi: {Age}  Chuyên ngành:{Specilization}";
    }
}