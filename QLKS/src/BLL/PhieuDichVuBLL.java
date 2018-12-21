/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package BLL;

import DAL.PhieuDichVuDAL;
import DTO.PhieuDichVu;
import java.util.ArrayList;

/**
 *
 * @author HUY
 */
public class PhieuDichVuBLL {
    PhieuDichVuDAL DAL = new PhieuDichVuDAL();
     //Tạo phiếu dịch vụ
    public boolean taoPhieuDichVu(String MaHD,String ngay){
        return DAL.taoPhieuDichVu(MaHD,ngay);
    }
    
    //cập nhập phiếu dịch vụ
    public boolean capnhapPhieuDV(String MaHD, String TriGia, String NgayLap){
        return DAL.capnhapPhieuDV(MaHD, TriGia, NgayLap);
    }
    
    //lấy mã phiếu dịch vụ
    public String layMaPhieuDV(String MaHD){
        return DAL.layMaPhieuDV(MaHD);
    }
    
    // xử ly thêm dịch vụ vào phiếu dịch vụ
    public boolean themCTDV(String ma, String tien){
        return DAL.themCTDV(ma, tien);
    }
    
    //Cập nhập thành tiền của phiếu dịch vụ
    public boolean capnhapTriGia(String ma, String tien){
        return DAL.capnhapTriGia(ma, tien);
    }
    
    
    ////Lấy mã hóa đơn từ mã phiếu dịch vụ
    public String layMaHD(String maPhieuDV){
        return DAL.layMaHD(maPhieuDV);
    }
    
    //Xử lý trả phòng
    public boolean xulyTraPhong(String mahd, String tien, String ngay){
        return DAL.xulyTraPhong(mahd, tien, ngay);
    }
}
