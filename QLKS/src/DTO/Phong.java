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
public class Phong {
    private String MaPhong, TenPhong, TenLoaiP, TinhTrang, GhiChu;
    
    //các phương thức get & set
    //Mã phòng
    public String getMaPhong(){
        return MaPhong;
    }
    public void setMaPhong(String ma){
        MaPhong = ma;
    }
    
    //Tên Phòng
    public String getTenPhong(){
        return TenPhong;
    }
    public void setTenPhong(String ten){
        TenPhong = ten;
    }        
    
    //Loại Phòng
    public String getTenLoaiP(){
        return TenLoaiP;
    }
    public void setTenLoaiP(String tenloai){
        TenLoaiP = tenloai;
    }
    
    //Trạng thái
    public String getTinhTrang(){
        return TinhTrang;
    }
    public void setTinhTrang(String tinhtrang){
        TinhTrang = tinhtrang;
    }
    
    //Ghi chú
    public String getGhiChu(){
        return GhiChu;
    }
    public void setGhiChu(String ghichu){
        GhiChu = ghichu;
    }
}
