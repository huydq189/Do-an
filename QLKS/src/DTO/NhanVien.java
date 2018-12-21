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
public class NhanVien {
    private String MaNV, TenNV, NamSinh, GioiTinh, ChucVu, SDT, DiaChi, GhiChu, MatKhau;
    
    //Mã nhân viên
    public String getMaNV(){
        return MaNV;
    }
    public void setMaNV(String ma){
        MaNV = ma;
    }
    
    //Tên nhân viên
    public String getTenNV(){
        return TenNV;
    }
    public void setTenNV(String ten){
        TenNV = ten;
    }
    
    //Năm sinh
    public String getNamSinh(){
        return NamSinh;
    }
    public void setNamSinh(String nam){
        NamSinh = nam;
    }
    
    //Giới tính
    public String getGioiTinh(){
        return GioiTinh;
    }
    public void setGioiTinh(String sex){
        GioiTinh = sex;
    }
    
    //Chức vụ
    public String getChucVu(){
        return ChucVu;
    }
    public void setChucVu(String chuc){
        ChucVu = chuc;
    }
    
    //Số điện thoại
    public String getSDT(){
        return SDT;
    }
    public void setSDT(String so){
        SDT = so;
    }
    
    //Địa chỉ 
    public String getDiaChi(){
        return DiaChi;
    }
    public void setDiaChi(String diachi){
        DiaChi = diachi;
    }
    
    //Ghi chú
    public String getGhiChu(){
        return GhiChu;
    }
    public void setGhiChu(String ghichu){
        GhiChu = ghichu;
    }

    
    //Mật khẩu đăng nhập
    public String getMatKhau(){
        return MatKhau;
    }
    public void setMatKhau(String s){
        MatKhau = s;
    }
}
