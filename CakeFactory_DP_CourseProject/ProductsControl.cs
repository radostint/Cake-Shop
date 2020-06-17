using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CakeFactory_DP_CourseProject.Decorators;

namespace CakeFactory_DP_CourseProject
{
    public partial class ProductsControl : UserControl
    {
        #region TreeColors
        private readonly Color AnchorNodeTextColor = Color.White;
        private readonly Color AnchorNodeTextBackground = Color.FromArgb(11, 66, 26);
        private readonly Color PrimaryItemTextColor = Color.Black;
        private readonly Color PrimaryItemTextBackground = Color.FromArgb(234, 199, 132);
        private readonly Color SubItemTextColor = Color.White;
        private readonly Color SubItemTextBackground = Color.FromArgb(155, 199, 132);
        #endregion
        private enum ItemNodeType
        {
            RootItem = 0,
            SubItem = 1
        }
        private OrderItems<Sweet> _orderItems;
        private ItemTreeNode _rootNode;
        private FinalOrder _finalOrder;
        private ItemTreeNode _lastItemNodeAdded;
        private Sweet _lastSweetAdded;
        private OrderItem<Sweet> _lastOrderItemAdded;
        public ProductsControl()
        {
            InitializeComponent();

            _orderItems = new OrderItems<Sweet>();
            buttonRemoveSelectedItem.Visible = false;
            InitOrderTree();
            RefreshOrderTree();
            panelExtrasCake.Enabled = false;
            panelExtrasPastry.Enabled = false;
            buttonRefreshOrder.Visible = false;
            buttonBuy.Visible = false;

        }
        private void InitOrderTree()
        {
            // Create the TreeView Root Node
            _rootNode = new ItemTreeNode();
            _rootNode.Text = "Вашата поръчка";
            _rootNode.ForeColor = AnchorNodeTextColor;
            _rootNode.BackColor = AnchorNodeTextBackground;
            _rootNode.ImageIndex = 0;
            _rootNode.SelectedImageIndex = 0;
            treeOrderList.Nodes.Add(_rootNode);
        }
        private void RefreshOrderTree()
        {
            foreach (var i in _orderItems.GetItems())
            {
                Sweet rootItem = i.RootItem();
                ItemTreeNode rootNode = AddRootItem(rootItem);
                foreach (var s in i.SubItems())
                {
                    AddSubItem(rootNode, s);
                }
            }

            treeOrderList.ExpandAll();
        }
        private ItemTreeNode AddRootItem(Sweet b)
        {
            // Store a reference to the last item added.
            _lastSweetAdded = b;
            _lastOrderItemAdded = new OrderItem<Sweet>(b);
            _orderItems.AddItem(_lastOrderItemAdded);

            var node = CreateNode(ItemNodeType.RootItem, b);
            _rootNode.Nodes.Add(node);

            treeOrderList.ExpandAll();
            UpdateTotals();
            return node;
        }

        private void AddSubItem(ItemTreeNode parentItemNode, Sweet b)
        {
            // TODO - Need to implement the following correctly.
            // parentItemNode is not yet used.
            _orderItems.AddItem(parentItemNode, new OrderItem<Sweet>(b));

            var node = CreateNode(ItemNodeType.SubItem, b);
            parentItemNode.Nodes.Add(node);

            UpdateTotals();
            treeOrderList.ExpandAll();
        }
        private ItemTreeNode CreateNode(ItemNodeType nodeType, Sweet b)
        {
            ItemTreeNode node = null;
            if (nodeType == ItemNodeType.RootItem)
            {
                node = CreateItemNode(b);
            }
            else if (nodeType == ItemNodeType.SubItem)
            {
                node = CreateSubItemNode(b);
            }
            return node;
        }
        private ItemTreeNode CreateItemNode(Sweet b)
        {
            var node = new ItemTreeNode(b);

            string cost = string.Format("{0,15:c}", $"{b.Cost} лв.");

            node.Text = string.Format("{0} {1}", b.Description, cost);
            node.ForeColor = PrimaryItemTextColor;
            node.BackColor = PrimaryItemTextBackground;
            node.ImageIndex = 1;
            node.SelectedImageIndex = 1;
            return node;
        }

        private ItemTreeNode CreateSubItemNode(Sweet b)
        {
            var node = new ItemTreeNode(b);
            // TODO - Need to figure out a way to get this to work.
            //string description = (b as BeverageDecorator).GetDecoratorDescriptionOnly();

            string cost = string.Format("{0,15:c}", $"[{b.Cost}]");

            node.Text = string.Format("{0,30} {1}", b.Description, cost);
            node.ForeColor = SubItemTextColor;
            node.BackColor = SubItemTextBackground;
            node.ImageIndex = 1;
            node.SelectedImageIndex = 1;
            return node;
        }
        private void UpdateTotals()
        {
            decimal cost = _orderItems.GetTotalCost();
            labelTotal.Text = string.Format("{0:c}", cost);
        }
        private void AddItemClickHandler(object sender, EventArgs e)
        {
            SweetsFactory chocoFactory = new ChocolateFactory();
            SweetsFactory creamFactory = new CreamFactory();
            Sweet obj = null;
            switch (((Button)sender).Name)
            {
                //Choco items
                case "buttonChocolateCakeSmall": obj = chocoFactory.CreateCake("small"); break;
                case "buttonChocolateCakeMedium": obj = chocoFactory.CreateCake("medium"); break;
                case "buttonChocolateCakeBig": obj = chocoFactory.CreateCake("big"); break;

                case "buttonChocolateMiniboxMuffin": obj = chocoFactory.CreatePastry("mini"); break;
                case "buttonStandardboxChocolateMuffin": obj = chocoFactory.CreatePastry("standard"); break;


                //Cream items
                case "buttonCreamCakeSmall": obj = creamFactory.CreateCake("small"); break;
                case "buttonCreamCakeMedium": obj = creamFactory.CreateCake("medium"); break;
                case "buttonCreamCakeBig": obj = creamFactory.CreateCake("big"); break;

                case "buttonCreamMiniboxMuffin": obj = creamFactory.CreatePastry("mini"); break;
                case "buttonStandardboxCreamMuffin": obj = creamFactory.CreatePastry("standard"); break;

                default:
                    // TODO - Need to catch this somewhere and display
                    throw new ArgumentNullException("Unknown Item Selected");
            }
            if (obj is Cake)
            {
                panelExtrasCake.Enabled = true;
                panelExtrasPastry.Enabled = false;
            }
            else
            {
                panelExtrasCake.Enabled = false;
                panelExtrasPastry.Enabled = true;
            }
            buttonBuy.Visible = true;
            _lastItemNodeAdded = AddRootItem(obj);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            panelExtrasCake.Enabled = false;
            panelExtrasPastry.Enabled = false;
            buttonRefreshOrder.Visible = false;
            treeOrderList.Nodes.Clear();
            _orderItems.Clear();
            UpdateTotals();
            InitOrderTree();
        }
        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void AddSubItemClickHandler(object sender, EventArgs e)
        {
            Sweet obj = null;
            switch (((Button)sender).Name)
            {
                case "buttonFruits": obj = new CakeFruitDecorator(_lastSweetAdded); break;
                case "buttonNuts": obj = new CakeNutsDecorator(_lastSweetAdded); break;
                case "buttonCakeSugar": obj = new CakeSugarDecorator(_lastSweetAdded); break;

                case "buttonCacao": obj = new PastryCacaoDecorator(_lastSweetAdded); break;
                case "buttonCaramel": obj = new PastryCaramelDecorator(_lastSweetAdded); break;
                case "buttonPastrySugar": obj = new PastrySugarDecorator(_lastSweetAdded); break;

                default:
                    // TODO - Need to catch this somewhere and display
                    throw new ArgumentNullException("Unknown Sub-Item Selected");
            }
            _orderItems.RemoveItem(_lastOrderItemAdded);
            _rootNode.LastNode.Remove();
            AddRootItem(obj);
            UpdateTotals();
        }

        private void buttonRemoveSelectedItem_Click(object sender, EventArgs e)
        {
            ItemTreeNode node = treeOrderList.SelectedNode as ItemTreeNode;

            if (node != _rootNode)
            {
                _orderItems.RemoveItem(node.Index);
                node.Remove();
                buttonRemoveSelectedItem.Visible = false;
                UpdateTotals();
                if (_orderItems.GetItems().Count() == 0)
                {
                    buttonRemoveSelectedItem.Visible = false;
                    panelExtrasCake.Enabled = false;
                    panelExtrasPastry.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Thought you'll break it,right?");
            }

        }

        private void treeOrderList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ItemTreeNode node = treeOrderList.SelectedNode as ItemTreeNode;
            if (node != _rootNode)
            {
                buttonRemoveSelectedItem.Visible = true;
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            _finalOrder = new FinalOrder();
            _finalOrder.orderItems = _orderItems;
            MessageBox.Show(_finalOrder.updateOrder());
            buttonBuy.Visible = false;
            buttonRefreshOrder.Visible = true;
        }

        private void buttonRefreshOrder_Click(object sender, EventArgs e)
        {
            string status = _finalOrder.updateOrder();
            if (status == "Вече сте получили вашата поръчка!")
            {
                Clear();
            }
            MessageBox.Show(status);
        }
    }
}
