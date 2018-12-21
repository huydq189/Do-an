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
public class DichVu {
    private String tenDV, maDV, giaDV, TinhTrang;
    
    //Mã dịch vụ
    public String getMaDV(){
        return maDV;
    }
    public void setMaDV(String ma){
        maDV = ma;
    }
    
    //Tên dịch vụ
    public String getTenDV(){
        return tenDV;
    }
    public void setTenDV(String ten){
        tenDV = ten;
    }
    
    //Giá dịch vụ
    public String getGiaDV(){
        return giaDV;
    }
    public void setGiaDV(String gia){
        giaDV = gia;
    }
    
    //Ghi chú
    public String getTinhTrang(){
        return TinhTrang;
    }
    public void setTinhTrang(String s){
        TinhTrang = s;
    }
}
