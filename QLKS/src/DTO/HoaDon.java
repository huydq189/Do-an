/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DTO;

/**
 *
 * @author HUY
 */
public class HoaDon {
    private String MaHD, MaPhieuThue, TienThuePhong, TienDichVu, TriGiaHD, NgayHD;
    
    //mã hóa đơn
    public String getMaHD(){
        return MaHD;
    }
    public void setMaHD(String ma){
        MaHD = ma;
    }
    
    //Mã phiếu thuê
    public String getMaPhieuThue(){
        return MaPhieuThue;
    }
    public void setMaPhieuThue(String ma){
        MaPhieuThue = ma;
    }
    
    //Tiền thuê phòng
    public String getTienThuePhong(){
        return TienThuePhong;
    }
    public void setTienThuePhong(String tien){
        TienThuePhong =  tien;
    }
    
    //Tiền dịch vụ
    public String getTienDichVu(){
        return TienDichVu;
    }
    public void setTienDichVu(String tien){
        TienDichVu = tien;
    }
    
    //trị giá hóa đơn
    public String getTriGiaHD(){
        return TriGiaHD;
    }
    public void setTriGiaHD(String tien){
        TriGiaHD = tien;
    }
    
    //Ngày hóa đơn
    public String getNgayHD(){
        return NgayHD;
    }
    public void setNgayHD(String ngay){
        NgayHD = ngay;
    }
}
