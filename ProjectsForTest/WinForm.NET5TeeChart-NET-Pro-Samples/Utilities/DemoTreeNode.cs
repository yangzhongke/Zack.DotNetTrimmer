using System;
using System.Windows.Forms;

namespace Steema.TeeChart.Samples
{
	/// <summary>
	/// Custom Tree node, used for Tee5Demo
	/// </summary>
	class DemoNode : TreeNode
	{
		private int fabsoluteindex;
		
		public DemoNode(string text)
		{
			this.Text = text;
		}


#if VS2005
		public new int Level
#else
		public int Level
#endif
		{
			get
			{
				TreeNode n = this.Parent;
				int l = 0;
				while (n != null) { l++; n = n.Parent;}	
				return l;
			}
		}

		public int AbsoluteIndex
		{
			get { return fabsoluteindex;}
			set { fabsoluteindex = value;}
				
		}

		public TreeNode MoveForward()
		{
			TreeNode res = null;
			// any children ?
			if (Nodes.Count > 0) 
				res = Nodes[0];
			// any siblings ?
			else if (NextNode != null)
				res = NextNode;
			else if (Parent != null)
			{ 
				TreeNode tmpNode = Parent;
				while (tmpNode.NextNode == null) tmpNode = tmpNode.Parent;
				res = tmpNode.NextNode;
			}

			return res;
		}
		public TreeNode MoveBackward()
		{
			TreeNode res = null;
			// any siblings
			if (PrevNode != null)
			{
				if (PrevNode.Nodes.Count > 0)
				{
					TreeNode tmpNode = PrevNode;
					while (tmpNode.Nodes.Count > 0) tmpNode = tmpNode.Nodes[tmpNode.Nodes.Count-1];
					res = tmpNode;
				}
				else res = PrevNode;
			}
			// parent node ?
			else if ((Parent != null))
				 res = Parent;				
			return res;
		}

	}

}