using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1;

namespace A_BFS
{
	class State
	{
		public List<int> trangThai { get; set; }
        public State nutCha { get; set; }
		public int heuris;
		//khởi tạo mặc định
        public State() { }

		//khởi tạo từ 1 mảng truyền vào
		public State(List<int> trangThai)
		{
			this.trangThai = trangThai;
		}
		//đếm ô sai của một trạng thái so với trạng thái đích, chính là giá trị của heuristic
		public int DemOSai(State trthaiDich)
		{
			int oSai = 0;
			for (int i = 0; i < trthaiDich.trangThai.Count; i++)
			{
				if (this.trangThai[i] != trthaiDich.trangThai[i])
				{
					oSai++;
				}
			}
			this.heuris = oSai;
			return oSai;
		}
		//hàm này để tách từ 1 mảng truyền vào theo mỗi bước đi(trái, phải, lên, xuống) sẽ tạo ra bao nhiêu mảng nữa
		//mỗi bước đi được sẽ đưa vào mangPhatSinh
		public List<List<int>> PhatSinhMangTuMotMang(List<int> mangBatKy)
		{
			List<List<int>> mangPhatSinh = new List<List<int>>();
			int i = mangBatKy.IndexOf(9);
			//để đi sang phải
			if (i % 3 < 2)
			{
				List<int> copy = new List<int>(mangBatKy);
				int temp = copy[i];
				copy[i] = copy[i + 1];
				copy[i + 1] = temp;
				mangPhatSinh.Add(copy);

			}
			//để đi sang trái
			if (i % 3 > 0)
			{
				List<int> copy = new List<int>(mangBatKy);
				int temp = copy[i];
				copy[i] = copy[i - 1];
				copy[i - 1] = temp;
				mangPhatSinh.Add(copy);
			}
			//để đi lên
			if (i - 3 >= 0)
			{
				List<int> copy = new List<int>(mangBatKy);
				int temp = copy[i];
				copy[i] = copy[i - 3];
				copy[i - 3] = temp;
				mangPhatSinh.Add(copy);
			}
			//để đi xuống
			if (i + 3 < mangBatKy.Count)
			{
				List<int> copy = new List<int>(mangBatKy);
				int temp = copy[i];
				copy[i] = copy[i + 3];
				copy[i + 3] = temp;
				mangPhatSinh.Add(copy);
			}
			return mangPhatSinh;
		}
		//đóng gói tất cả mảng có thể phát sinh từ 1 mảng truyền vào (là hàm phía trên) thành 1 state
		public List<State> PhanTachTrangThai()
		{
			List<State> phatSinh = new List<State>();
			List<List<int>> mangPhatSinh = PhatSinhMangTuMotMang(this.trangThai);
			for (int i = 0; i < mangPhatSinh.Count; i++)
			{
				State dongGoi = new State(mangPhatSinh[i]);
				phatSinh.Add(dongGoi);
				//gán nút cha là dongGoi
				dongGoi.nutCha = this;
			}
			return phatSinh;
		}
		public bool KiemTraDenDich(State mangGoc)
		{
			bool denDich = true;

			for (int i = 0; i < mangGoc.trangThai.Count; i++)
			{
				if (this.trangThai[i] != mangGoc.trangThai[i])
				{
					denDich = false;
					break;
				}
			}
			return denDich;
		}
		//in ra một bước đi (1 state) của mỗi lần duyệt
		public void inRaMotState()
		{
			int i = 0;
			foreach (var item in this.trangThai)
			{
				Console.Write(item + " ");
				i += 1;
				if (i % 3 == 0)
					Console.Write("\n");
			}
			Console.Write("\n\n");
		}
	}

	class BFS
	{
		State trangThaiDau;
		State trangThaiDich;
		//danh sách các trạng thái đã duyệt
        List<State> trangThaiDaDuyet = null;
		public int dem = 0;

        public BFS(State trangThaiDau, State trangThaiDich)
		{
			this.trangThaiDau = trangThaiDau;
			this.trangThaiDich = trangThaiDich;
            trangThaiDaDuyet = new List<State>();
        }

		//kiểm tra 2 trạng thái có giống nhau hay không?
		public bool KiemTraTrangThaiTrung(State a, State b)
		{
			bool giongnhau = true;
			for (int i = 0; i < b.trangThai.Count; i++)
			{
				if (a.trangThai[i] != b.trangThai[i])
				{
					giongnhau = false;
				}
			}
			return giongnhau;
		}
		//kiểm tra một trạng thái đã có trong danh sách các trạng thái đã duyệt hay chưa?
		public bool KiemTraTrangThaiChuaTrongList(List<State> list, State check)
		{
			bool contains = false;
			foreach (var item in list)
			{
				if (KiemTraTrangThaiTrung(item, check) == true)
					contains = true;
			}
			return contains;
		}

		public List<State> Solve()
		{
			dem = 0;
			List<State> ketQua = new List<State>();
			//hàng đợi enqueue thêm vào cuối, và dequeue lấy ra ở đầu và remove luôn ptu đó
			Queue<State> danhSachDinhDuyet = new Queue<State>();

			danhSachDinhDuyet.Enqueue(trangThaiDau);

			while (danhSachDinhDuyet.Count > 0)
			{
				State ptLayRa = danhSachDinhDuyet.Dequeue();
                trangThaiDaDuyet.Add(ptLayRa);
				dem++;
				//dòng này để in ra các trạng thái mảng đã duyệt dưới dạng ma trận 3x3
				//ptLayRa.inRaMotState();

				if (ptLayRa.KiemTraDenDich(trangThaiDich) == true)
				{
					Console.WriteLine("Ban da chien thang!.....");
					break;
				}

				//ptLayRa đem đi phân tách coi được mấy trạng thái
				List<State> hungPhanTachTrangThai = ptLayRa.PhanTachTrangThai();
				foreach (var item in hungPhanTachTrangThai)
				{
					if (item.KiemTraDenDich(trangThaiDich) == true)
					{
						Console.WriteLine("Ban da chien thang!.....");
						//lằn vết lúc này sẽ trả về danh sách đường đi nhưng bị ngược => qua nút Giải reverse nó
						LanVet(ketQua, item);
						//in ra đường đi tìm được trên console dưới dạng ma trận 3x3
						inRaDuongDi(ketQua);
						return ketQua;
					}
					if (!KiemTraTrangThaiChuaTrongList(trangThaiDaDuyet, item) )
					{                    
						danhSachDinhDuyet.Enqueue(item);
					}
				}
			}
			return ketQua;
		}
		public void SapXepCacTrangThaiTheoHeuris(List<State> temp)
		{
			for (int i = 0; i < temp.Count-1; i++)
			{
				for (int j = i+1; j < temp.Count; j++)
				{
					if (temp[i].heuris > temp[j].heuris)
					{
						//hoán đổi 2 trạng thái
						State t = temp[i];
						temp[i] = temp[j];
						temp[j] = t;
					}
				}
			}
		}
		public List<State> Solve_BestFirstSearch()
		{
			dem = 0;
			List<State> ketQua = new List<State>();
			//hàng đợi enqueue thêm vào cuối, và dequeue lấy ra ở đầu và remove luôn ptu đó
			List<State> danhSachDinhDuyet = new List<State>();

			danhSachDinhDuyet.Add(trangThaiDau);

			while (danhSachDinhDuyet.Count > 0)
			{
				State ptLayRa = danhSachDinhDuyet[0];
				dem++;
				trangThaiDaDuyet.Add(ptLayRa);
				danhSachDinhDuyet.RemoveAt(0);
			
				//dòng này để in ra các trạng thái mảng đã duyệt dưới dạng ma trận 3x3
				//ptLayRa.inRaMotState();

				if (ptLayRa.KiemTraDenDich(trangThaiDich) == true)
				{
					Console.WriteLine("Ban da chien thang!.....");
					break;
				}

				//ptLayRa đem đi phân tách coi được mấy trạng thái
				List<State> hungPhanTachTrangThai = ptLayRa.PhanTachTrangThai();
				foreach (var item in hungPhanTachTrangThai)
				{
					if (item.KiemTraDenDich(trangThaiDich) == true)
					{
						Console.WriteLine("Ban da chien thang!.....");
						//lằn vết lúc này sẽ trả về danh sách đường đi nhưng bị ngược => qua nút Giải reverse nó
						LanVet(ketQua, item);
						//in ra đường đi tìm được trên console dưới dạng ma trận 3x3
						inRaDuongDi(ketQua);
						Console.WriteLine(dem);
						return ketQua;
					}
					if (!KiemTraTrangThaiChuaTrongList(trangThaiDaDuyet, item))
					{
						item.DemOSai(trangThaiDich);
						danhSachDinhDuyet.Add(item);
						SapXepCacTrangThaiTheoHeuris(danhSachDinhDuyet);
					}
				}
			}

			return ketQua;
		}
		//lằn vết để đưa mỗi nút cha đã gán trước đó vào trong list kết quả
		public void LanVet(List<State> duongDi, State n)
		{
			State hienTai = n;
			duongDi.Add(hienTai);

			while (hienTai.nutCha != null)
			{
				hienTai = hienTai.nutCha;
				duongDi.Add(hienTai);
			}
		}
		//in ra đường đi đã tìm được
		public void inRaDuongDi(List<State>temp)
		{
			foreach (var item in temp)
			{
				item.inRaMotState();
			}
		}
	}
}
