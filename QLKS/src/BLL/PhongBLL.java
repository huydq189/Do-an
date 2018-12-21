/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package BLL;

import DAL.PhongDAL;
import DTO.Phong;
import java.sql.Statement;
import java.util.ArrayList;

/**
 *
 * @author HUY
 */
public class PhongBLL {
    
    //tạo đối tượng PhongDAL
    PhongDAL DAL = new PhongDAL();
    
    //lấy danh sách phòng
    public ArrayList<Phong> getAllPhong(){
        return DAL.getAllPhong();
    }
    
    
    
    //lấy phòng theo tầng
     public ArrayList<Phong> layPhongTheoTang(int tang){
         return DAL.layPhongTheoTang(tang);
     }
     
    //Lấy Mã phòng theo tên phòng
     public String getIDbyName(String ten){
         return DAL.getIDbyName(ten);
     }

     //cho thuê -  cập nhập trạng thái
     public boolean updateTrangThai(String maphong, String trangthai){
         return DAL.updateTrangThai(maphong, trangthai);
     }
     
     
     //lấy tên phòng theo mã phòng
    public String layTenPhong(String maPhong){
        return DAL.layTenPhong(maPhong);
    }
    
    //Lấy giá phòng theo mã phòng
    public String[] layGiaTheoMaPhong(String maPhong){
        return DAL.layGiaTheoMaPhong(maPhong);
    }
    
    
    //Xử lí trả phòng
    public boolean xulyTraPhong(String maPhong){
        return DAL.xulyTraPhong(maPhong);
    }
}
