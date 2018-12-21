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
public class PhieuThuePhong {
    private String MaPhong, MaKH, NgayBDThue, NgayKTThue, SoLuongKH, KHNgoaiQuoc, MaNV, TrangThaiPhieu;

    //Mã phòng
    public String getMaPhong(){
        return MaPhong;
    }
    public void setMaPhong(String ma){
        MaPhong = ma;
    }
    
    //Tên Khách hàng
    public String getMaKH(){
        return MaKH;
    }
    public void setMaKH(String ma){
        MaKH = ma;
    }
    
    //Ngày bắt đầu thuê
    public String getNgayBD(){
        return NgayBDThue;
    }
    public void setNgayBD(String ngaybd){
        NgayBDThue = ngaybd;
    }
    
    //Ngày trả phòng
    public String getNgayKTThue(){
        return NgayKTThue;
    }
    public void setNgayKTThue(String ngay){
        NgayKTThue = ngay;
    }
    
    //Số lượng khách hàng
    public String getSoLuongKH(){
        return SoLuongKH;
    }
    public void setSoLuongKH(String soluong){
        SoLuongKH = soluong;
    }
    
    //Khách hàng nước ngoài trả về 1 nếu có KH nước ngoài và ngược lại
    public String getKHNgoaiQuoc(){
        return KHNgoaiQuoc;
    }
    public void setKHNgoaiQuoc(String kh){
        KHNgoaiQuoc = kh;
    }
    

    //Mã nhân viên
    public String getMaNV(){
        return MaNV;
    }
    public void setMaNV(String ma){
        MaNV = ma;
    }
    
    //Trạng thái phiếu 1:  mới nhất , 0: là phiếu cũ
    public String getTrangThaiPhieu(){
        return TrangThaiPhieu;
    }
    public void setTrangThaiPhieu(String s){
        TrangThaiPhieu = s;
    }
    
}
