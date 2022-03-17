using System;
using System.Drawing;
using Steema.TeeChart.Drawing;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
  public class Grid3DUtils
  {

    private Grid3DUtils() {}

    private static double ClosestValue(TeeChart.Styles.Custom3D src, double x, double z)
    {
      double maxdist = 1.0e+300;
      int closer = -1;
      double tmpx, tmpz, dist;
      for (int i=0; i<src.Count; i++)
      {
        tmpx = src.XValues[i] - x;
        tmpz = src.ZValues[i] - z;
        dist = Math.Sqrt(tmpx*tmpx + tmpz*tmpz);
        if (dist<maxdist)
        {
          maxdist = dist;
          closer = i;
        }
      }
      if (closer == -1) return 0.0;
      else return src.YValues[closer];
    }
    
    public static void CreateGrid(TeeChart.Styles.Custom3D src, TeeChart.Styles.Custom3DGrid dst, int gridsize)
    { 
      double tmpminx = src.XValues.Minimum;
      double tmpminz = src.ZValues.Minimum;
      double tmpxfact = src.XValues.Range/(double)gridsize;
      double tmpzfact = src.ZValues.Range/(double)gridsize;
      double tmpx, tmpz,tmpy;
      int iindex;

      dst.BeginUpdate();
      try
      {
        dst.Clear();
        dst.IrregularGrid = true;
        dst.NumXValues = gridsize;
        dst.NumZValues = gridsize;

        // loop all grid cells
        for (int x=1; x<=dst.NumXValues; x++)
        {
          tmpx = tmpminx + (x-1)*tmpxfact;  
          for (int z=1; z<=dst.NumZValues; z++)
          {
            tmpz = tmpminz+(z-1)*tmpzfact;
            tmpy = ClosestValue(src,tmpx,tmpz);
            iindex = dst[x,z];
            if (iindex != -1) 
            {
              dst.YValues.Value[iindex] = tmpy;
              dst.XValues.Value[iindex] = tmpx;
              dst.ZValues.Value[iindex] = tmpz;
            }
            else dst[x,z] = dst.Add(tmpx,tmpy,tmpz);
          }
        }
      }
      finally
      {
        dst.EndUpdate();
      }
    }

    public static void SmoothGrid(TeeChart.Styles.Custom3DGrid series)
    { 
      double tmpx, tmpz, tmpy;
      
      series.BeginUpdate();
      try
      {
        series.IrregularGrid = true;
        int tmpnumx = series.NumXValues;
        int tmpnumz = series.NumZValues;
        for (int x=1; x<tmpnumx; x++)
        {
          for (int z=1; z<tmpnumz; z++)
          {
            tmpx = 0.5*(series.XValues[series[x,z]] + series.XValues[series[x+1,z]]);
            tmpz = 0.5*(series.ZValues[series[x,z]] + series.ZValues[series[x,z+1]]);
            tmpy = 0.25*(2*series.YValues[series[x,z]]+series.YValues[series[x+1,z]]
              +series.YValues[series[x,z+1]]);      
            series.Add(tmpx,tmpy,tmpz);
            series.Add(series.XValues[series[x,z]],
              0.5*(series.YValues[series[x,z]]+series.YValues[series[x,z+1]]),
              tmpz);
            series.Add(tmpx,
              0.5*(series.YValues[series[x,z]]+series.YValues[series[x+1,z]]),
              series.ZValues[series[x,z]]);
          }
          series.Add(0.5*(series.XValues[series[x,tmpnumz]]+series.XValues[series[x+1,tmpnumz]]),
            0.5*(series.YValues[series[x,tmpnumz]]+series.YValues[series[x+1,tmpnumz]]),
            series.ZValues[series[x,tmpnumz]]);
        }

        for (int z=1; z<tmpnumz; z++)
        {
          series.Add(series.XValues[series[tmpnumx,z]],
            0.5*(series.YValues[series[tmpnumx,z]]+series.YValues[series[tmpnumx,z+1]]),
            0.5*(series.ZValues[series[tmpnumx,z]]+series.ZValues[series[tmpnumx,z+1]]));
        }
      }
      finally
      {
        series.EndUpdate();
        series.Repaint();
      }
    }
  }
}