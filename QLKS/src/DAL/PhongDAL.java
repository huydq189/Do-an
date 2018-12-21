/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAL;

import DTO.Phong;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

/**
 *
 * @author HUY
 */
public class PhongDAL extends DataAccessHelper{
    
    //Lấy danh sách phòng
    public ArrayList<Phong> getAllPhong(){
        String SQL = "SELECT TenPhong,TenLoaiP,TinhTrang,PHONG.GhiChu FROM PHONG,LOAIPHONG WHERE PHONG.MaLoaiP = LOAIPHONG.MaLoaiP";
       
        ArrayList<Phong> temp = new ArrayList<Phong>();
        try{
            getConnect();
            PreparedStatement ps = conn.prepareStatement(SQL);
            ResultSet rs = ps.executeQuery();
            if(rs!=null)
                while(rs.next()){
                    
                    Phong p = new Phong();
                    p.setTenPhong(rs.getString("TenPhong"));
                    p.setTenLoaiP(rs.getString("TenLoaiP"));
                    p.setTinhTrang(rs.getString("TinhTrang"));
                    p.setGhiChu(rs.getString("GhiChu"));
                    temp.add(p);
                }
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return temp;
    }
    
    
    
    //lấy danh sách phòng thêm từng tầng của khách sạn
    public ArrayList<Phong> layPhongTheoTang(int tang){
        ArrayList<Phong> temp = new ArrayList<>();
        String SQL = "SELECT TenPhong,TenLoaiP,TinhTrang FROM PHONG,LOAIPHONG WHERE PHONG.MaLoaiP = LOAIPHONG.MaLoaiP and maphong like '%P"+tang+"%' and TinhTrang!=N'Tạm ngưng'";
        try{
            getConnect();
            PreparedStatement ps = conn.prepareStatement(SQL);
            ResultSet rs = ps.executeQuery();
            if(rs!=null)
                while(rs.next()){
                    Phong p = new Phong();
                    p.setTenPhong(rs.getString("TenPhong"));
                    p.setTenLoaiP(rs.getString("TenLoaiP"));
                    p.setTinhTrang(rs.getString("TinhTrang"));
                    temp.add(p);
                }
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return temp;
    }
    
    
    //lấy mã phòng theo tên phòng 
    public String getIDbyName(String ten){
        String SQL = "select maphong from phong where tenphong=N'"+ten+"'";
        try{
            getConnect();
            PreparedStatement ps = conn.prepareStatement(SQL);
            ResultSet rs = ps.executeQuery();
            if(rs!=null&&rs.next())
                return rs.getString("MaPhong");
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return "";
    }
    
    // cho thuê phòng hoặc trả phòng -  cập nhập lại trạng thái phòng
    public boolean updateTrangThai(String maphong, String trangthai){
        String SQL = "Update Phong set TinhTrang=N'"+trangthai+"' where maphong='"+maphong+"'";
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
    
    //lấy tên phòng theo mã phòng
    public String layTenPhong(String maPhong){
        String SQL = "Select TenPhong from Phong where MaPhong='"+maPhong+"'";
        try{
            getConnect();
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(SQL);
            if(rs!=null&&rs.next())
                return rs.getString("TenPhong");
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return "";
    }
    
    //Lấy giá phòng theo mã phòng
    public String[] layGiaTheoMaPhong(String maPhong){
        String SQL = "Select GiaQuaDem,GiaGioDau From LoaiPhong,Phong where LoaiPhong.MaLoaiP = Phong.MaLoaiP and MaPhong='"+maPhong+"'";
        String[] gia = new String[2];
        try{
            getConnect();
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(SQL);
            if(rs!=null&&rs.next()){
                gia[0] = rs.getString("GiaQuaDem");
                gia[1] = rs.getString("GiaGioDau");
                return gia;
            }
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }   
        return gia;
    }
    
    //Xử lí trả phòng
    public boolean xulyTraPhong(String maPhong){
        String SQL = "Update Phong set TinhTrang=N'Trống' where MaPhong='"+maPhong+"'";
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
}
