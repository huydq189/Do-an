/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAL;

import DTO.NhanVien;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

/**
 *
 * @author HUY
 */
public class NhanVienDAL extends DataAccessHelper{
    //Lấy tất cả nhân viên
    public ArrayList<NhanVien> getAll(){
        ArrayList<NhanVien> temp = new ArrayList<NhanVien>();
        String SQL = "Select * from NhanVien";
        try{
            getConnect();
            PreparedStatement ps = conn.prepareStatement(SQL);
            ResultSet rs = ps.executeQuery();
            if(rs!=null)
                while(rs.next()){
                    NhanVien nv = new NhanVien();
                    nv.setMaNV(rs.getString("MaNV"));
                    nv.setTenNV(rs.getString("TenNV"));
                    nv.setNamSinh(rs.getString("NamSinh"));
                    nv.setGioiTinh(rs.getString("GioiTinh"));
                    nv.setChucVu(rs.getString("ChucVu"));
                    nv.setSDT(rs.getString("SDT"));
                    nv.setDiaChi(rs.getString("DiaChi"));
                    nv.setGhiChu(rs.getString("GhiChu"));
                    temp.add(nv);
                }
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return temp;
    }

    // sửa dữ liệu
    public boolean suaNhanVien(String ma, String ten, String nam, String gioitinh, String chuc, String sdt, String diachi, String ghichu, String macu){
        String SQL = "Update NhanVien set MaNV='"+ma+"', TenNV=N'"+ten+"', NamSinh='"+nam+"', GioiTinh=N'"+gioitinh+"', ChucVu=N'"+chuc+"', SDT='"+sdt+"', DiaChi=N'"+diachi+"', GhiChu=N'"+ghichu+"' where MaNV='"+macu+"'";
        try{
           getConnect();
           Statement st = conn.createStatement();
           int rs = st.executeUpdate(SQL);
           if(rs > 0)
               return true;
           getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return false;
    }
     
     
    // thêm dữ liệu
    public boolean themNhanVien(String ma, String ten, String nam, String gioitinh, String chuc, String sdt, String diachi, String ghichu, String matkhau){
        String SQL = "Insert Into NhanVien values('"+ma+"',N'"+ten+"','"+nam+"',N'"+gioitinh+"',N'"+chuc+"','"+sdt+"',N'"+diachi+"',N'"+ghichu+"','"+matkhau+"')";
        try{
            getConnect();
            Statement st = conn.createStatement();
            int rs = st.executeUpdate(SQL);
            if(rs > 0)
                return true;
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return false;
    }
    
    //lay tên Nhân viên bằng mã
    public String getNamebyID(String ma){
        String SQL = "Select TenNV from NhanVien where MaNV='"+ma+"'";
        try{
            getConnect();
            PreparedStatement ps = conn.prepareStatement(SQL);
            ResultSet rs = ps.executeQuery();
            if(rs!=null&&rs.next())
                return rs.getString("TenNV");
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return "";
    }
    
    //Lấy mã nhân viên bằng tên
    public String getIDbyName(String ten){
        String SQL = "Select MaNV from NhanVien where TenNV=N'"+ten+"'";
        try{
            getConnect();
            PreparedStatement ps = conn.prepareStatement(SQL);
            ResultSet rs = ps.executeQuery();
            if(rs!=null&&rs.next())
                return rs.getString("MaNV");
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return "";
    }
    
    
    //kiểm tra đăng nhập
    public boolean checkLogin(String ten, String pass){
        String SQL = "select * from NhanVien where MaNV='"+ten+"' and MatKhau='"+pass+"'";
        try{
            getConnect();
            PreparedStatement ps = conn.prepareStatement(SQL);
            ResultSet rs = ps.executeQuery();
            if(rs!=null&&rs.next())
                return true;
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return false;
    }
    
    
    //Tìm kiếm nhân viên
    public ArrayList<NhanVien> timkiem(String key){
        ArrayList<NhanVien> temp = new ArrayList<NhanVien>();
        String SQL = "Select * from NhanVien where tenNV like N'%"+key+"%'";
        try{
            getConnect();
            PreparedStatement ps = conn.prepareStatement(SQL);
            ResultSet rs = ps.executeQuery();
            if(rs!=null)
                while(rs.next()){
                    NhanVien nv = new NhanVien();
                    nv.setMaNV(rs.getString("MaNV"));
                    nv.setTenNV(rs.getString("TenNV"));
                    nv.setNamSinh(rs.getString("NamSinh"));
                    nv.setGioiTinh(rs.getString("GioiTinh"));
                    nv.setChucVu(rs.getString("ChucVu"));
                    nv.setSDT(rs.getString("SDT"));
                    nv.setDiaChi(rs.getString("DiaChi"));
                    nv.setGhiChu(rs.getString("GhiChu"));
                    temp.add(nv);
                }
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return temp;
    }
    
    //sửa mật khâu
    public boolean  suaMatKhau(String manv, String matkhau){
        String SQL = "Update NhanVien set MatKhau='"+matkhau+"' where manv='"+manv+"'";
        try{
            getConnect();
            Statement st = conn.createStatement();
            int rs = st.executeUpdate(SQL);
            if(rs>0)
                return true;
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return false;
    }
    
//Lấy chức vụ bởi mã nhân viên
    public String layChucVu(String manv){
        String SQL = "Select ChucVu from NhanVien where manv='"+manv+"'";
        try{
            getConnect();
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(SQL);
            if(rs!=null&&rs.next())
                return rs.getString("ChucVu");
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }            
        return "";
    }
}
