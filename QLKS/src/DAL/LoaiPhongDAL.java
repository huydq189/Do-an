/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package DAL;

import DTO.LoaiPhong;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Statement;
import java.util.ArrayList;

/**
 *
 * @author HUY
 */
public class LoaiPhongDAL extends DataAccessHelper{
    
    //lấy tất cả loại phòng
    public ArrayList<LoaiPhong> getAllLoaiPhong(){
        String SQL = "SELECT * FROM LOAIPHONG";
        ArrayList<LoaiPhong> temp = new ArrayList<LoaiPhong>();
        try{
            getConnect();
            PreparedStatement ps = conn.prepareStatement(SQL);
            ResultSet rs = ps.executeQuery();
            if(rs!=null)
                while(rs.next()){
                    LoaiPhong loai = new LoaiPhong();
                    loai.setMaLoaiP(rs.getString("MaLoaiP"));
                    loai.setTenLoaiP(rs.getString("TenLoaiP"));
                    loai.setGiaQuaDem(rs.getString("GiaQuaDem"));
                    loai.setGiaGioDau(rs.getString("GiaGioDau"));
                    temp.add(loai);
                }
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return temp;
    }
    
    
    // lấy mã loại phòng bằng tên loại phòng
    public String getIdByName(String ten){
        String SQL = "SELECT MaLoaiP FROM LOAIPHONG WHERE TenLoaiP=N'"+ten+"'";
        
        try{
            getConnect();
            PreparedStatement ps = conn.prepareStatement(SQL);
            ResultSet rs = ps.executeQuery();
            if(rs!=null&&rs.next())
                return rs.getString("MaLoaiP");
            getClose();
        }catch(Exception e){
            e.printStackTrace();
        }
        return "";
    }
    
    
}
