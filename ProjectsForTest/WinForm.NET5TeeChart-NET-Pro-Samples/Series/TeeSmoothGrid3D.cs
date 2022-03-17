using System;
using Steema.TeeChart;

namespace Steema.TeeChart.Samples
{
	public class TeeSmoothGrid3D
	{
		public static void SmoothGrid3D(Steema.TeeChart.Styles.Custom3DGrid Series) 
		{
			double tmpX, tmpY, tmpZ;
			int tmpNumX = Series.NumXValues;
			int tmpNumZ = Series.NumZValues;

			Series.BeginUpdate();
			Series.IrregularGrid = true;

			for(int x=1; x < tmpNumX; ++x) 
			{
				for(int z=1; z < tmpNumZ; ++z) 
				{
					tmpX = (Series.XValues[Series[x,z]] + Series.XValues[Series[x+1,z]]) * 0.5;
					tmpZ = (Series.ZValues[Series[x,z]] + Series.ZValues[Series[x,z+1]]) * 0.5;

					tmpY = (Series.YValues[Series[x,z]] 
						+ Series.YValues[Series[x+1,z]]
						+ Series.YValues[Series[x,z]]
						+ Series.YValues[Series[x,z+1]]) * 0.25;

					Series.Add(tmpX,tmpY,tmpZ);
				
					Series.Add(Series.XValues[Series[x,z]], 
						(Series.YValues[Series[x,z]] + Series.YValues[Series[x,z+1]]) * 0.5, 
						tmpZ);

					Series.Add(tmpX, 
						(Series.YValues[Series[x,z]] + Series.YValues[Series[x+1,z]]) * 0.5,
						Series.ZValues[Series[x,z]]);

				}
				Series.Add( (Series.XValues[Series[x,tmpNumZ]]+Series.XValues[Series[x+1,tmpNumZ]])*0.5,
					( Series.YValues[Series[x,tmpNumZ]]+ Series.YValues[Series[x+1,tmpNumZ]] )*0.5,
					Series.ZValues[Series[x,tmpNumZ]]);
			}

			for(int z=1; z < tmpNumZ; ++z ) 
			{
				Series.Add(Series.XValues[Series[tmpNumX,z]],
					( Series.YValues[Series[tmpNumX,z]]+ Series.YValues[Series[tmpNumX,z+1]] )*0.5,
					( Series.ZValues[Series[tmpNumX,z]] + Series.ZValues[Series[tmpNumX,z+1]] )*0.5
					);

			}

			Series.EndUpdate();
			Series.Repaint();
		}
	}
}
