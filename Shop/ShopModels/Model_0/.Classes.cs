/* ========================================================================
 * Copyright (c) 2005-2021 The OPC Foundation, Inc. All rights reserved.
 *
 * OPC Foundation MIT License 1.00
 *
 * Permission is hereby granted, free of charge, to any person
 * obtaining a copy of this software and associated documentation
 * files (the "Software"), to deal in the Software without
 * restriction, including without limitation the rights to use,
 * copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the
 * Software is furnished to do so, subject to the following
 * conditions:
 *
 * The above copyright notice and this permission notice shall be
 * included in all copies or substantial portions of the Software.
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.
 *
 * The complete license agreement can be found here:
 * http://opcfoundation.org/License/MIT/1.00/
 * ======================================================================*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.Serialization;
using Opc.Ua;

namespace Shop
{
    #region ProductDTOState Class
    #if (!OPCUA_EXCLUDE_ProductDTOState)
    /// <summary>
    /// Stores an instance of the ProductDTO ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class ProductDTOState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public ProductDTOState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ObjectTypes.ProductDTO, Namespaces.cas, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAABwAAABodHRwOi8vY2FzLmV1L1VBL0NvbW1TZXJ2ZXIv/////wRggAIBAAAAAQASAAAAUHJvZHVj" +
           "dERUT0luc3RhbmNlAQEBAAEBAQABAAAA/////wYAAAAVYIkKAgAAAAEACQAAAFByb2R1Y3RJZAEBAgAA" +
           "LgBEAgAAAAAb/////wEB/////wAAAAAVYIkKAgAAAAEACwAAAFByb2R1Y3ROYW1lAQEDAAAuAEQDAAAA" +
           "AAz/////AQH/////AAAAABVgiQoCAAAAAQAMAAAAUHJvZHVjdFByaWNlAQEEAAAuAEQEAAAAAAr/////" +
           "AQH/////AAAAABVgiQoCAAAAAQAPAAAAUHJvZHVjdFF1YW50aXR5AQEFAAAuAEQFAAAAABv/////AQH/" +
           "////AAAAABVgiQoCAAAAAQALAAAAUHJvZHVjdFR5cGUBAQYAAC4ARAYAAAAADP////8BAf////8AAAAA" +
           "BGGCCgQAAAABABAAAABEZWNyZWFzZVF1YW50aXR5AQEdAAAvAQEdAB0AAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState ProductId
        {
            get
            {
                return m_productId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_productId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_productId = value;
            }
        }

        /// <remarks />
        public PropertyState<string> ProductName
        {
            get
            {
                return m_productName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_productName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_productName = value;
            }
        }

        /// <remarks />
        public PropertyState<float> ProductPrice
        {
            get
            {
                return m_productPrice;
            }

            set
            {
                if (!Object.ReferenceEquals(m_productPrice, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_productPrice = value;
            }
        }

        /// <remarks />
        public PropertyState ProductQuantity
        {
            get
            {
                return m_productQuantity;
            }

            set
            {
                if (!Object.ReferenceEquals(m_productQuantity, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_productQuantity = value;
            }
        }

        /// <remarks />
        public PropertyState<string> ProductType
        {
            get
            {
                return m_productType;
            }

            set
            {
                if (!Object.ReferenceEquals(m_productType, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_productType = value;
            }
        }

        /// <remarks />
        public MethodState DecreaseQuantity
        {
            get
            {
                return m_decreaseQuantityMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_decreaseQuantityMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_decreaseQuantityMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_productId != null)
            {
                children.Add(m_productId);
            }

            if (m_productName != null)
            {
                children.Add(m_productName);
            }

            if (m_productPrice != null)
            {
                children.Add(m_productPrice);
            }

            if (m_productQuantity != null)
            {
                children.Add(m_productQuantity);
            }

            if (m_productType != null)
            {
                children.Add(m_productType);
            }

            if (m_decreaseQuantityMethod != null)
            {
                children.Add(m_decreaseQuantityMethod);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BrowseNames.ProductId:
                {
                    if (createOrReplace)
                    {
                        if (ProductId == null)
                        {
                            if (replacement == null)
                            {
                                ProductId = new PropertyState(this);
                            }
                            else
                            {
                                ProductId = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = ProductId;
                    break;
                }

                case BrowseNames.ProductName:
                {
                    if (createOrReplace)
                    {
                        if (ProductName == null)
                        {
                            if (replacement == null)
                            {
                                ProductName = new PropertyState<string>(this);
                            }
                            else
                            {
                                ProductName = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ProductName;
                    break;
                }

                case BrowseNames.ProductPrice:
                {
                    if (createOrReplace)
                    {
                        if (ProductPrice == null)
                        {
                            if (replacement == null)
                            {
                                ProductPrice = new PropertyState<float>(this);
                            }
                            else
                            {
                                ProductPrice = (PropertyState<float>)replacement;
                            }
                        }
                    }

                    instance = ProductPrice;
                    break;
                }

                case BrowseNames.ProductQuantity:
                {
                    if (createOrReplace)
                    {
                        if (ProductQuantity == null)
                        {
                            if (replacement == null)
                            {
                                ProductQuantity = new PropertyState(this);
                            }
                            else
                            {
                                ProductQuantity = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = ProductQuantity;
                    break;
                }

                case BrowseNames.ProductType:
                {
                    if (createOrReplace)
                    {
                        if (ProductType == null)
                        {
                            if (replacement == null)
                            {
                                ProductType = new PropertyState<string>(this);
                            }
                            else
                            {
                                ProductType = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ProductType;
                    break;
                }

                case BrowseNames.DecreaseQuantity:
                {
                    if (createOrReplace)
                    {
                        if (DecreaseQuantity == null)
                        {
                            if (replacement == null)
                            {
                                DecreaseQuantity = new MethodState(this);
                            }
                            else
                            {
                                DecreaseQuantity = (MethodState)replacement;
                            }
                        }
                    }

                    instance = DecreaseQuantity;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState m_productId;
        private PropertyState<string> m_productName;
        private PropertyState<float> m_productPrice;
        private PropertyState m_productQuantity;
        private PropertyState<string> m_productType;
        private MethodState m_decreaseQuantityMethod;
        #endregion
    }
    #endif
    #endregion

    #region OrderDTOState Class
    #if (!OPCUA_EXCLUDE_OrderDTOState)
    /// <summary>
    /// Stores an instance of the OrderDTO ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class OrderDTOState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public OrderDTOState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ObjectTypes.OrderDTO, Namespaces.cas, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAABwAAABodHRwOi8vY2FzLmV1L1VBL0NvbW1TZXJ2ZXIv/////wRggAIBAAAAAQAQAAAAT3JkZXJE" +
           "VE9JbnN0YW5jZQEBHgABAR4AHgAAAP////8HAAAAFWCJCgIAAAABAAcAAABPcmRlcklkAQEfAAAuAEQf" +
           "AAAAABv/////AQH/////AAAAAARggAoBAAAAAQAFAAAASXRlbXMBASAAAC8AOiAAAAD/////AAAAABVg" +
           "iQoCAAAAAQAKAAAAQ2xpZW50TmFtZQEBIQAALgBEIQAAAAAM/////wEB/////wAAAAAVYIkKAgAAAAEA" +
           "DgAAAENsaWVudExhc3ROYW1lAQEiAAAuAEQiAAAAAAz/////AQH/////AAAAABVgiQoCAAAAAQANAAAA" +
           "Q2xpZW50QWRkcmVzcwEBIwAALgBEIwAAAAAM/////wEB/////wAAAAAEYYIKBAAAAAEAFAAAAEdldFRv" +
           "dGFsSXRlbVF1YW50aXR5AQEkAAAvAQEkACQAAAABAf////8AAAAABGGCCgQAAAABAA0AAABHZXRUb3Rh" +
           "bFByaWNlAQElAAAvAQElACUAAAABAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState OrderId
        {
            get
            {
                return m_orderId;
            }

            set
            {
                if (!Object.ReferenceEquals(m_orderId, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_orderId = value;
            }
        }

        /// <remarks />
        public BaseObjectState Items
        {
            get
            {
                return m_items;
            }

            set
            {
                if (!Object.ReferenceEquals(m_items, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_items = value;
            }
        }

        /// <remarks />
        public PropertyState<string> ClientName
        {
            get
            {
                return m_clientName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_clientName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_clientName = value;
            }
        }

        /// <remarks />
        public PropertyState<string> ClientLastName
        {
            get
            {
                return m_clientLastName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_clientLastName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_clientLastName = value;
            }
        }

        /// <remarks />
        public PropertyState<string> ClientAddress
        {
            get
            {
                return m_clientAddress;
            }

            set
            {
                if (!Object.ReferenceEquals(m_clientAddress, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_clientAddress = value;
            }
        }

        /// <remarks />
        public MethodState GetTotalItemQuantity
        {
            get
            {
                return m_getTotalItemQuantityMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_getTotalItemQuantityMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_getTotalItemQuantityMethod = value;
            }
        }

        /// <remarks />
        public MethodState GetTotalPrice
        {
            get
            {
                return m_getTotalPriceMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_getTotalPriceMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_getTotalPriceMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_orderId != null)
            {
                children.Add(m_orderId);
            }

            if (m_items != null)
            {
                children.Add(m_items);
            }

            if (m_clientName != null)
            {
                children.Add(m_clientName);
            }

            if (m_clientLastName != null)
            {
                children.Add(m_clientLastName);
            }

            if (m_clientAddress != null)
            {
                children.Add(m_clientAddress);
            }

            if (m_getTotalItemQuantityMethod != null)
            {
                children.Add(m_getTotalItemQuantityMethod);
            }

            if (m_getTotalPriceMethod != null)
            {
                children.Add(m_getTotalPriceMethod);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BrowseNames.OrderId:
                {
                    if (createOrReplace)
                    {
                        if (OrderId == null)
                        {
                            if (replacement == null)
                            {
                                OrderId = new PropertyState(this);
                            }
                            else
                            {
                                OrderId = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = OrderId;
                    break;
                }

                case BrowseNames.Items:
                {
                    if (createOrReplace)
                    {
                        if (Items == null)
                        {
                            if (replacement == null)
                            {
                                Items = new BaseObjectState(this);
                            }
                            else
                            {
                                Items = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = Items;
                    break;
                }

                case BrowseNames.ClientName:
                {
                    if (createOrReplace)
                    {
                        if (ClientName == null)
                        {
                            if (replacement == null)
                            {
                                ClientName = new PropertyState<string>(this);
                            }
                            else
                            {
                                ClientName = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ClientName;
                    break;
                }

                case BrowseNames.ClientLastName:
                {
                    if (createOrReplace)
                    {
                        if (ClientLastName == null)
                        {
                            if (replacement == null)
                            {
                                ClientLastName = new PropertyState<string>(this);
                            }
                            else
                            {
                                ClientLastName = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ClientLastName;
                    break;
                }

                case BrowseNames.ClientAddress:
                {
                    if (createOrReplace)
                    {
                        if (ClientAddress == null)
                        {
                            if (replacement == null)
                            {
                                ClientAddress = new PropertyState<string>(this);
                            }
                            else
                            {
                                ClientAddress = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = ClientAddress;
                    break;
                }

                case BrowseNames.GetTotalItemQuantity:
                {
                    if (createOrReplace)
                    {
                        if (GetTotalItemQuantity == null)
                        {
                            if (replacement == null)
                            {
                                GetTotalItemQuantity = new MethodState(this);
                            }
                            else
                            {
                                GetTotalItemQuantity = (MethodState)replacement;
                            }
                        }
                    }

                    instance = GetTotalItemQuantity;
                    break;
                }

                case BrowseNames.GetTotalPrice:
                {
                    if (createOrReplace)
                    {
                        if (GetTotalPrice == null)
                        {
                            if (replacement == null)
                            {
                                GetTotalPrice = new MethodState(this);
                            }
                            else
                            {
                                GetTotalPrice = (MethodState)replacement;
                            }
                        }
                    }

                    instance = GetTotalPrice;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private PropertyState m_orderId;
        private BaseObjectState m_items;
        private PropertyState<string> m_clientName;
        private PropertyState<string> m_clientLastName;
        private PropertyState<string> m_clientAddress;
        private MethodState m_getTotalItemQuantityMethod;
        private MethodState m_getTotalPriceMethod;
        #endregion
    }
    #endif
    #endregion

    #region BasketItemDTOState Class
    #if (!OPCUA_EXCLUDE_BasketItemDTOState)
    /// <summary>
    /// Stores an instance of the BasketItemDTO ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class BasketItemDTOState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public BasketItemDTOState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(ObjectTypes.BasketItemDTO, Namespaces.cas, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
            base.Initialize(context);
            Initialize(context, InitializationString);
            InitializeOptionalChildren(context);
        }

        /// <summary>
        /// Initializes the instance with a node.
        /// </summary>
        protected override void Initialize(ISystemContext context, NodeState source)
        {
            InitializeOptionalChildren(context);
            base.Initialize(context, source);
        }

        /// <summary>
        /// Initializes the any option children defined for the instance.
        /// </summary>
        protected override void InitializeOptionalChildren(ISystemContext context)
        {
            base.InitializeOptionalChildren(context);
        }

        #region Initialization String
        private const string InitializationString =
           "AQAAABwAAABodHRwOi8vY2FzLmV1L1VBL0NvbW1TZXJ2ZXIv/////wRggAIBAAAAAQAVAAAAQmFza2V0" +
           "SXRlbURUT0luc3RhbmNlAQEmAAEBJgAmAAAA/////wMAAAAEYIAKAQAAAAEAEQAAAEJhc2tldEl0ZW1Q" +
           "cm9kdWN0AQEnAAAvADonAAAA/////wAAAAAVYIkKAgAAAAEAEgAAAEJhc2tldEl0ZW1RdWFudGl0eQEB" +
           "KAAALgBEKAAAAAAb/////wEB/////wAAAAAEYYIKBAAAAAEADQAAAEdldFRvdGFsUHJpY2UBASkAAC8B" +
           "ASkAKQAAAAEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public BaseObjectState BasketItemProduct
        {
            get
            {
                return m_basketItemProduct;
            }

            set
            {
                if (!Object.ReferenceEquals(m_basketItemProduct, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_basketItemProduct = value;
            }
        }

        /// <remarks />
        public PropertyState BasketItemQuantity
        {
            get
            {
                return m_basketItemQuantity;
            }

            set
            {
                if (!Object.ReferenceEquals(m_basketItemQuantity, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_basketItemQuantity = value;
            }
        }

        /// <remarks />
        public MethodState GetTotalPrice
        {
            get
            {
                return m_getTotalPriceMethod;
            }

            set
            {
                if (!Object.ReferenceEquals(m_getTotalPriceMethod, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_getTotalPriceMethod = value;
            }
        }
        #endregion

        #region Overridden Methods
        /// <summary>
        /// Populates a list with the children that belong to the node.
        /// </summary>
        /// <param name="context">The context for the system being accessed.</param>
        /// <param name="children">The list of children to populate.</param>
        public override void GetChildren(
            ISystemContext context,
            IList<BaseInstanceState> children)
        {
            if (m_basketItemProduct != null)
            {
                children.Add(m_basketItemProduct);
            }

            if (m_basketItemQuantity != null)
            {
                children.Add(m_basketItemQuantity);
            }

            if (m_getTotalPriceMethod != null)
            {
                children.Add(m_getTotalPriceMethod);
            }

            base.GetChildren(context, children);
        }

        /// <summary>
        /// Finds the child with the specified browse name.
        /// </summary>
        protected override BaseInstanceState FindChild(
            ISystemContext context,
            QualifiedName browseName,
            bool createOrReplace,
            BaseInstanceState replacement)
        {
            if (QualifiedName.IsNull(browseName))
            {
                return null;
            }

            BaseInstanceState instance = null;

            switch (browseName.Name)
            {
                case BrowseNames.BasketItemProduct:
                {
                    if (createOrReplace)
                    {
                        if (BasketItemProduct == null)
                        {
                            if (replacement == null)
                            {
                                BasketItemProduct = new BaseObjectState(this);
                            }
                            else
                            {
                                BasketItemProduct = (BaseObjectState)replacement;
                            }
                        }
                    }

                    instance = BasketItemProduct;
                    break;
                }

                case BrowseNames.BasketItemQuantity:
                {
                    if (createOrReplace)
                    {
                        if (BasketItemQuantity == null)
                        {
                            if (replacement == null)
                            {
                                BasketItemQuantity = new PropertyState(this);
                            }
                            else
                            {
                                BasketItemQuantity = (PropertyState)replacement;
                            }
                        }
                    }

                    instance = BasketItemQuantity;
                    break;
                }

                case BrowseNames.GetTotalPrice:
                {
                    if (createOrReplace)
                    {
                        if (GetTotalPrice == null)
                        {
                            if (replacement == null)
                            {
                                GetTotalPrice = new MethodState(this);
                            }
                            else
                            {
                                GetTotalPrice = (MethodState)replacement;
                            }
                        }
                    }

                    instance = GetTotalPrice;
                    break;
                }
            }

            if (instance != null)
            {
                return instance;
            }

            return base.FindChild(context, browseName, createOrReplace, replacement);
        }
        #endregion

        #region Private Fields
        private BaseObjectState m_basketItemProduct;
        private PropertyState m_basketItemQuantity;
        private MethodState m_getTotalPriceMethod;
        #endregion
    }
    #endif
    #endregion
}