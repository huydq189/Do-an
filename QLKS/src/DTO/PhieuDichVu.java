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
public class PhieuDichVu {
    private String MaHD, MaPhieuDV, TriGia, NgayLap;
    
    // mã hóa đơn
    public String getMaHD(){
        return MaHD;
    }
    public void setMaHD(String s){
        MaHD = s;
    }
    
    //Mã phiêu dịch vụ
    public String getMaPhieuDV(){
        return MaPhieuDV;
    }
    public void setMaPhieuDV(String s){
        MaPhieuDV = s;
    }
    
    //Trị giá
    public String getTriGia(){
        return TriGia;
    }
    public void setTriGia(String s){
        TriGia = s; 
    }
    
    
    //Ngay lập
    public String getNgayLap(){
        return NgayLap;
    }
    public void setNgayLap(String s){
        NgayLap = s;
    }

}
