using System;


namespace Bai1
{
    enum TypeCanBo
    {
        CongNhan,
        NhanVien,
        KySu
    }
    class QLCB
    {
        private List<CanBo> canBos;


        public QLCB()
        {
            canBos = new List<CanBo>();
        }


        public void AddCanBo()
        {
            CanBo canBo = null;
            Console.WriteLine("Nhập tên nhân viên mới:");
            string Name = Console.ReadLine();

        ReadGender:

            Console.WriteLine("Nhập giới tính nhân viên mới (Male, Female, Other):");
            string input = Console.ReadLine();
            Gender gender;
            if (!Enum.TryParse(input, true, out gender))
            {
                Console.WriteLine("Vui lòng chỉ nhập một trong các giới tính Male, Female và Other!");
                goto ReadGender;
            }

            
        ReadAge:
            Console.WriteLine("Nhập tuổi nhân viên mới:");
            input = Console.ReadLine();
            int Age;
            if(!int.TryParse(input, out Age))
            {
                Console.WriteLine("Vui lòng nhập một số hợp lệ cho tuôi của nhân viên");
                goto ReadAge;
            }

        ReadTypeCanBo:

            Console.Write("Điền loại cán bộ (CongNhan, Kysu, NhanVien):");
            input = Console.ReadLine();
            TypeCanBo typeCanBo;
            if (!Enum.TryParse(input, true, out typeCanBo))
            {
                Console.WriteLine("Vui lòng chỉ nhập một trong các loại cán bộ CongNhan, Kysu và NhanVien!");
                goto ReadTypeCanBo;
            }

            switch (typeCanBo)
            {
                case TypeCanBo.CongNhan:
                    Console.WriteLine("Điền bậc của công nhân:");
                ReadRank:
                    input = Console.ReadLine();
                    int Rank;
                    if (!int.TryParse(input, out Rank) || Rank < 1 || Rank > 10)
                    {
                        Console.WriteLine("Vui lòng nhập bậc công nhân trong khoảng từ 1 đến 10!");
                        goto ReadRank;
                    }
                    canBo = new CongNhan(Name, gender, Age, Rank);
                    break;
                case TypeCanBo.KySu:
                    Console.WriteLine("Điền chuyên ngành của kỹ sư:");
                    string Specialization = Console.ReadLine();
                    canBo = new KySu(Name, gender, Age, Specialization);
                    break;
                case TypeCanBo.NhanVien:
                    Console.WriteLine("Điền công việc của nhân viên:");
                    string Job = Console.ReadLine();
                    canBo = new NhanVien(Name, gender, Age, Job);
                    break;
            }

            canBos.Add(canBo);
            Console.WriteLine("Nhập nhân viên thành công! Đang quay trở lại menu chính...");
        }

        public List<CanBo> FindCanBo(string Name)
        {
            return canBos.Where(canbo => canbo.Name.Contains(Name)).ToList();
        }
        public List<CanBo> ListCanBo()
        {
            return canBos;
        }
        public void Print(List<CanBo> list)
        {
            foreach (var canBo in list)
            {
                Console.WriteLine(canBo.ToString());
            }
        }
        public void Quit()
        {
            Console.WriteLine("Đang tắt chương trình...");
        }
    }
}
