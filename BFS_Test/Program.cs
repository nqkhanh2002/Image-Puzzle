//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BFS_Test
//{
//	class State
//	{
//		public List<int> trangThai;
//		public State nutCha;

//		public State(List<int> trangThai, State nutCha)
//		{
//			this.trangThai = trangThai;
//			this.nutCha = nutCha;
//		}

//		//hàm này để tách từ 1 mảng truyền vào theo mỗi bước đi(trái, phải, lên, xuống) sẽ tạo ra bao nhiêu mảng nữa
//		public List<List<int>> PhatSinhMangTuMotMang(List<int> mangBatKy)
//		{
//			List<List<int>> mangPhatSinh = new List<List<int>>();
//			int i = mangBatKy.IndexOf(9);
//			//để đi sang phải
//			if (i % 3 < 2)
//			{
//				List<int> copy = new List<int>(mangBatKy);
//				int temp = copy[i];
//				copy[i] = copy[i + 1];
//				copy[i + 1] = temp;
//				mangPhatSinh.Add(copy);
				
//			}
//			//để đi sang trái
//			if (i % 3 > 0)
//			{
//				List<int> copy = new List<int>(mangBatKy);
//				int temp = copy[i];
//				copy[i] = copy[i - 1];
//				copy[i - 1] = temp;
//				mangPhatSinh.Add(copy);
//			}
//			//để đi lên
//			if (i - 3 >= 0)
//			{
//				List<int> copy = new List<int>(mangBatKy);
//				int temp = copy[i];
//				copy[i] = copy[i - 3];
//				copy[i - 3] = temp;
//				mangPhatSinh.Add(copy);
//			}
//			//để đi xuống
//			if (i + 3 < mangBatKy.Count)
//			{
//				List<int> copy = new List<int>(mangBatKy);
//				int temp = copy[i];
//				copy[i] = copy[i + 3];
//				copy[i + 3] = temp;
//				mangPhatSinh.Add(copy);
//			}
//			return mangPhatSinh;
//		}
//		//đóng gói tất cả mảng có thể phát sinh từ 1 mảng truyền vào (là hàm phía trên) thành 1 state
//		public List<State> PhanTachTrangThai()
//		{
//			List<State> phatSinh = new List<State>();
//			List<List<int>> mangPhatSinh = PhatSinhMangTuMotMang(this.trangThai);
//			for (int i = 0; i < mangPhatSinh.Count; i++)
//			{
//				State dongGoi = new State(mangPhatSinh[i], null);				
//				phatSinh.Add(dongGoi);
//				//dongGoi.nutCha = dongGoi;
//			}
//			return phatSinh;
//		}
//		public bool KiemTraDenDich(State mangGoc)
//		{
//			bool denDich = true;

//			for (int i = 0; i < mangGoc.trangThai.Count; i++)
//			{
//				if (this.trangThai[i] != mangGoc.trangThai[i])
//				{
//					denDich = false;
//					break;
//				}
//			}
//			return denDich;
//		}
//		public void inRaMotState()
//		{
//			int i = 0;
//			foreach(var item in this.trangThai)
//			{
//				Console.Write(item +" ");
//				i += 1;
//				if(i%3==0)
//					Console.Write("\n");
//			}
//			Console.Write("\n\n");
//		}
//	}

//	class BFS
//	{
//		State trangThaiDau;
//		State trangThaiDich;

//		List<State> Path = new List<State>();

//		public BFS(State trangThaiDau, State trangThaiDich)
//		{
//			this.trangThaiDau = trangThaiDau;
//			this.trangThaiDich = trangThaiDich;
//		}

//		public bool KiemTraTrangThaiTrung(State a, State b)
//		{
//			bool giongnhau = true;
//			for (int i = 0; i < b.trangThai.Count ; i++)
//			{
//				if (a.trangThai[i] != b.trangThai[i])
//				{
//					giongnhau = false;
//				}
//			}
//			return giongnhau;
//		}
//		public  bool KiemTraTrangThaiChuaTrongList(Queue<State>list, State check)
//		{
//			bool contains = false;
//			foreach (var item in list)
//			{
//				if (KiemTraTrangThaiTrung(item, check)==true)
//					contains = true;
//			}
//			return contains;
//		}
//		public List<State> Solve()
//		{
//			List<State> ketQua = new List<State>();
//			Queue<State> Visited = new Queue<State>();
//			Queue<State> danhSachDinhDuyet = new Queue<State>();

//			danhSachDinhDuyet.Enqueue(trangThaiDau);

//			while (danhSachDinhDuyet.Count > 0)
//			{
//				State ptLayRa = danhSachDinhDuyet.Dequeue();
//				Visited.Enqueue(ptLayRa);
//				//ptLayRa.inRaMotState();

//				if (ptLayRa.KiemTraDenDich(trangThaiDich) == true)
//				{
//					Console.WriteLine("Ban da chien thang!.....");
//					break;
//				}
//				List<State> hungPhanTachTrangThai = ptLayRa.PhanTachTrangThai();
//				for (int i = 0; i < hungPhanTachTrangThai.Count; i++)
//				{
//					if (hungPhanTachTrangThai[i].KiemTraDenDich(trangThaiDich) == true)
//					{
//						Console.WriteLine("Ban da chien thang!.....");
//						LanVet(ketQua, item);
//						return ketQua;
//					}
//					if(!KiemTraTrangThaiChuaTrongList(Visited, hungPhanTachTrangThai[i]))
//					{
//						danhSachDinhDuyet.Enqueue(hungPhanTachTrangThai[i]);
//						Path[i] = 
//					}		
//				}
//			}
//			return ketQua;
//		}

//		public void LanVet(List<State> duongDi, State n)
//		{
//			State hienTai = n;
//			duongDi.Add(hienTai);

//			while (hienTai.nutCha != null)
//			{
//				hienTai = hienTai.nutCha;
//				duongDi.Add(hienTai);
//			}
//		}

//		public void inRaDuongDi()
//		{
//			List<State> ketQuaCuoiCung = Solve();
//			foreach (var item in ketQuaCuoiCung)
//			{
//				item.inRaMotState();
//			}
//		}
//	}

//	class Program
//	{
//		static void Main(string[] args)
//		{
//			List<int> mangDau = new List<int> { 1, 2, 3, 7, 4, 6, 5, 9, 8 };
//			List<int> mangCuoi = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//			State trThaiDau = new State(mangDau,null);
//			State trThaiCuoi = new State(mangCuoi,null);
//			BFS bfs = new BFS(trThaiDau, trThaiCuoi);
//			List<State> ketQuaCuoiCung = bfs.Solve();
//			//bfs.inRaDuongDi();
//			Console.ReadKey();
//		}
//	}
//}
