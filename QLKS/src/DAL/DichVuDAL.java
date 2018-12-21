/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAL;

import DTO.DichVu;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

/**
 *
 * @author HUY
 */
public class DichVuDAL extends DataAccessHelper{
    
    //lấy tất cả dịch vụ
    public ArrayList<DichVu> getAll(){
        ArrayList<DichVu> temp = new ArrayList<DichVu>();
        String SQl = "Select * From DichVu";
        try{
            getConnect();
            PreparedStatement ps = conn.prepareStatement(SQl);
            ResultSet rs = ps.executeQuery();
            if(rs!=null)
                while(rs.next()){
                    DichVu dv = new DichVu();
                    dv.setMaDV(rs.getString("MaDV"));
                    dv.setTenDV(rs.getString("TenDV"));
                    dv.setGiaDV(rs.getString("DonGia"));
                    dv.setTinhTrang(rs.getString("TinhTrang"));
                    temp.add(dv);
                }
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return temp;
    }
    
    
 
    
    //Lấy danh sách dịch đang trong trạng thái sẵn sàng
    public ArrayList<DichVu> layDichVuSanSang(){
        ArrayList<DichVu> temp = new ArrayList<DichVu>();
        String SQl = "Select * From DichVu where TinhTrang=N'Còn hàng'";
        try{
            getConnect();
            PreparedStatement ps = conn.prepareStatement(SQl);
            ResultSet rs = ps.executeQuery();
            if(rs!=null)
                while(rs.next()){
                    DichVu dv = new DichVu();
                    
                    dv.setTenDV(rs.getString("TenDV"));
                    dv.setGiaDV(rs.getString("DonGia"));

                    temp.add(dv);
                }
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return temp;
    }
    
    //Lấy mã dịch vụ bằng tên dịch vụ
    public String layMaDV(String tenDV){
        String SQL = "Select MaDV from DichVu where TenDV=N'"+tenDV+"'";
        try{
            getConnect();
            Statement st = conn.createStatement();
            ResultSet rs = st.executeQuery(SQL);
            if(rs!=null&&rs.next())
                return rs.getString("MaDV");
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return "";
    }
    
   
    
    
}
