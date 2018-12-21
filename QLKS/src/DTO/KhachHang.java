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
public class KhachHang {
    private String tenKH, GioiTinh, CMND, DiaChi;
    
    
    //hàm khởi tạo mặc với tham số mặc nhiên

    /**
     *
     */
    public KhachHang(){
       tenKH = "";
       GioiTinh = "";
       CMND = "";
       DiaChi = "";
    }


    //tên khách hàng
    public String getTenKH(){
        return tenKH;
    }
    public void setTenKH(String ten){
        tenKH = ten;
    }
    
    //giới tính
    public String getGioiTinh(){
        return GioiTinh;
    }
    public void setGioiTinh(String sex){
        GioiTinh = sex;
    }
    
    //CMND 
    public String getCMND(){
        return CMND;
    }
    public void setCMND(String s){
        CMND = s;
    }
    
    //địa chỉ
    public String getDiaChi(){
        return DiaChi;
    }
    public void setDiaChi(String s){
        DiaChi = s;
    }
    
}
