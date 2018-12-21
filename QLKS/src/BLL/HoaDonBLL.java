/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package BLL;

import DAL.HoaDonDAL;
import DTO.HoaDon;
import java.util.ArrayList;
import java.util.Vector;

/**
 *
 * @author HUY
 */
public class HoaDonBLL {
    HoaDonDAL DAL = new HoaDonDAL();
    
    
    //tạo hóa đơn mới
    public boolean khoiTaoHD(String maphieuthue){
        return DAL.khoiTaoHD(maphieuthue);
    }
    
    //lấy mã hóa đơn ứng với phiếu thuê phongg
    public String getMaHD(String maphieuthue){
        return DAL.getMaHD(maphieuthue);
    }
    
    
    //Lấy mã phiếu thuê bằng mã hóa đơn
    public String layMaPhieuThue(String maHD){
        return DAL.layMaPhieuThue(maHD);
    }
    
    //xử lý trả phongg
    public boolean xulyTraPhong(String mahd, String tienDV, String tienThue, String trigia, String ngay, String manv){
        return DAL.xulyTraPhong(mahd, tienDV, tienThue, trigia, ngay, manv);
    }
}
