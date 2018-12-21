/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DTO;

import java.math.BigDecimal;

/**
 *
 * @author HUY
 */
public class LoaiPhong {
    private String MaLoaiP, TenLoaiP, GhiChu, GiaQuaDem, GiaGioDau;
    
    //mã loại
    public String getMaLoaiP(){
        return MaLoaiP;
    }
    public void setMaLoaiP(String ma){
        MaLoaiP = ma;
    }
    
    //Tên loại
    public String getTenLoaiP(){
        return TenLoaiP;
    }
    public void setTenLoaiP(String ten){
        TenLoaiP = ten;
    }
    
//    //Ghi chú
//    public String getGhiChu(){
//        return GhiChu;
//    }
//    public void setGhiChu(String ghichu){
//        GhiChu = ghichu;
//    }
//    
    //Giá qua đêm
    public String getGiaQuaDem(){
        return GiaQuaDem;
    }
    public void setGiaQuaDem(String tien){
        GiaQuaDem = tien;
    }
    
    //Giá giờ đầu
    public String getGiaGioDau(){
        return GiaGioDau;
    }
    public void setGiaGioDau(String tien){
        GiaGioDau = tien;
    }
}
