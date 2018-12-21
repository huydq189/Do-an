/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package BLL;

import DAL.PhieuThuePhongDAL;
import DTO.PhieuThuePhong;
import java.util.ArrayList;


/**
 *
 * @author HUY
 */
public class PhieuThuePhongBLL {
    PhieuThuePhongDAL DAL = new PhieuThuePhongDAL();
    
    //thêm phiếu thuê phòng
    public boolean themPhieuMoi(String maphong, String makh, String soLuong, String ngoaiquoc, String manv, String ngayBD, String ngayKT){
        return DAL.themPhieuMoi(maphong, makh, soLuong, ngoaiquoc, manv, ngayBD, ngayKT);
    }
    
    //lấy thông tin phiếu thuê của phòng dang cho thuê
    public PhieuThuePhong getInfo(String maphong, String  trangthai){
        return DAL.getInfo(maphong, trangthai);
    }
    
    //Lấy mã phiếu thuê phòng mới nhất ứng với phòng 
    public String getMaPhieuMoi(String maphong){
       return DAL.getMaPhieuMoi(maphong);
    }
    
     //lấy thông tin phiếu thuê bằng mã phiếu thuê
    public PhieuThuePhong layThongTin(String maphieu){
        return DAL.layThongTin(maphieu);
    }
    
    //Xử lí trả phòng
    public boolean xulyTraPhong(String maphieu, String ngayKT){
        return DAL.xulyTraPhong(maphieu, ngayKT);
    }
    
    //Lấy danh sách mã phiếu thuê ứng với makh
    public ArrayList<String> layDSMaPhieuThue(String makh){
        return DAL.layDSMaPhieuThue(makh);
    }
    
    //Sửa mã khách hàng thành mã khách ảo của tất cả phiếu thuê của khách hàng này
    public boolean suaMaKH(String maKHao, String maKH){
        return DAL.suaMaKH(maKHao, maKH);
    }
}
