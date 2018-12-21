/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAL;

import DTO.KhachHang;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;
import javax.swing.DefaultComboBoxModel;

/**
 *
 * @author HUY
 */
public class KhachHangDAL extends DataAccessHelper{
    
    //lấy CMND dựa theo một vài kí tự đầu tiên
    public DefaultComboBoxModel getCMNDbyKey(String key){
        DefaultComboBoxModel model = new DefaultComboBoxModel();
        String SQL = "Select CMND from KhachHang where CMND Like '"+key+"%'";
        try{
            getConnect();
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(SQL);
            model.addElement("");
            if(rs!=null)
                while(rs.next()){
                    model.addElement(rs.getString("CMND"));
                }
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return model;
    }
    
    //lấy thông tin khách hàng dựa vào cmnd
    public KhachHang getKHbyCMND(String cmnd){
        KhachHang khachhang = new KhachHang();
        String SQL = "select * from KhachHang where CMND='"+cmnd+"'";
        try{
            getConnect();
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(SQL);
            if(rs!=null&&rs.next()){
                khachhang.setTenKH(rs.getString("TenKH"));
                khachhang.setGioiTinh(rs.getString("GioiTinh"));
                khachhang.setCMND(rs.getString("CMND"));
                khachhang.setDiaChi(rs.getString("DiaChi"));
            }
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return khachhang;
    }
    
    //kiểm tra xem đã là khách hàng hay chưa
    public boolean checkKH(String CMND){
        String SQL = "Select * from KhachHang where CMND='"+CMND+"'";
        try{
            getConnect();
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(SQL);
            if(rs!=null&&rs.next())
                return true;
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return false;
    }
    
    
    //thêm khách hàng mới
    public boolean themKH(String cm, String ten, String gioitinh, String diachi){
        String SQL = "insert into KhachHang values(N'"+ten+"',N'"+gioitinh+"','"+cm+"',N'"+diachi+"')";
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
    
    //Lấy mã khách hàng dựa trên CMND
    public String layMaKH(String cmnd){
        String SQL = "Select MaKH From KhachHang where CMND='"+cmnd+"'";
        try{
            getConnect();
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(SQL);
            if(rs!=null&&rs.next())
                return rs.getString("MaKH");
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return "";
    }
    
    //lấy thông tin khách hàng dựa vào makh
    public KhachHang layThongTin(String makh){
        String SQL = "Select * from KhachHang where MaKH='"+makh+"'";
        KhachHang khachhang = new KhachHang();
        try{
            getConnect();
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(SQL);
            if(rs!=null&&rs.next()){
                khachhang.setCMND(rs.getString("CMND"));
                khachhang.setTenKH(rs.getString("TenKh"));
                khachhang.setGioiTinh(rs.getString("GioiTinh"));
                khachhang.setDiaChi(rs.getString("DiaChi"));
            }
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return khachhang;
    }
    
    //Lấy tên khách hàng dựa vào mã khách hàng
    public String layTen(String makh){
        String SQL = "Select TenKH from KhachHang where MaKH="+makh;
        try{
            getConnect();
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(SQL);
            if(rs!=null&&rs.next())
                return rs.getString("TenKH");
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return "";
    }
     //Lấy CMDMD dựa vào mã khách hàng
    public String layCMND(String makh){
        String SQL = "Select CMND from KhachHang where MaKH="+makh;
        try{
            getConnect();
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(SQL);
            if(rs!=null&&rs.next())
                return rs.getString("CMND");
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return "";
    }
    
    //Lấy danh sách khách hàng
    public ArrayList<KhachHang> layDanhSach(){
        ArrayList<KhachHang> temp = new ArrayList<>();
        String SQL = "Select * from KhachHang";
        try{
            getConnect();
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(SQL);
            if(rs!=null)
                while(rs.next()){
                    KhachHang kh = new KhachHang();
                    kh.setTenKH(rs.getString("TenKH"));
                    kh.setCMND(rs.getString("CMND"));
                    kh.setGioiTinh(rs.getString("GioiTinh"));
                    kh.setDiaChi(rs.getString("DiaChi"));
                    temp.add(kh);
                }
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return temp;
    }
    
   
    //Lấy mã khách hàng dựa vào cmnd
    public String layMaTuCMND(String cmnd){
        String SQL = "Select MaKH from KhachHang where CMND='"+cmnd+"'";
        try{
            getConnect();
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(SQL);
            if(rs!=null&&rs.next())
                return rs.getString("MaKH");
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return "";
    }
    
   
}
