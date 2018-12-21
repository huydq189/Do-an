/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DTO;

/**
 *
 * @author RumIT
 */
public class CT_PhieuDichVu {
    private String MaPhieuDV, MaDV, SoLuong, ThanhTien, TenDV, DonGia;
    
    //mã phiếu DV
    public String getMaPhieuDV(){
        return MaPhieuDV;
    }
    public void setMaPhieuDV(String ma){
        MaPhieuDV = ma;
    }
    
    //Mã dịch vụ
    public String getMaDV(){
        return MaDV;
    }
    public void setMaDV(String ma){
        MaDV = ma;
    }
    
    //Số lượng
    public String getSoLuong(){
        return SoLuong;
    }
    public void setSoLuong(String so){
        SoLuong = so;
    }
    
    //Thành tiền
    public String getThanhTien(){
        return ThanhTien;
    }
    public void setThanhTien(String tien){
        ThanhTien = tien;
    }


    //Tên dịch vụ
    public String getTenDV(){
        return TenDV;
    }
    public void setTenDV(String ten){
        TenDV = ten;    
    }
    
    //Đơn giá
    public String getDonGia(){
        return DonGia;
    }
    public void setDonGia(String gia){
        DonGia = gia;
    }
}
