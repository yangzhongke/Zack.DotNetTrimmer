using System;
using System.Drawing;
using Steema.TeeChart.Drawing;
using Steema.TeeChart.Styles;

namespace Steema.TeeChart.Samples
{
  /// <summary>
  /// Summary description for BarSize.
  /// </summary>
  public class BarSize : Bar
  {
    private ValueList sizeValues;
    private int ISize;

    public BarSize() : this(null) { }

    public BarSize(Chart c) : base(c) 
    { 
      sizeValues=new ValueList(this,"xSize");
    }

    private void InternalCalcBarSize(int valueIndex)
    {
      if(sizeValues[valueIndex]==0)
        IBarSize=ISize;
      else
        IBarSize=GetHorizAxis.CalcSizeValue(sizeValues[valueIndex]);
    }

    protected override bool InternalClicked(int valueIndex, Point p)
    {
      InternalCalcBarSize(valueIndex);
      return(base.InternalClicked(valueIndex,p));
    }

    public override void DrawValue(int valueIndex)
    {
      if(valueIndex==firstVisible) ISize=IBarSize;

      InternalCalcBarSize(valueIndex);

      // Call default Bar drawing method.
      base.DrawValue(valueIndex);
    }
    
    public ValueList SizeValues 
    {
      get { return sizeValues; }
      set { SetValueList(sizeValues,value); }
    }
  }
}
