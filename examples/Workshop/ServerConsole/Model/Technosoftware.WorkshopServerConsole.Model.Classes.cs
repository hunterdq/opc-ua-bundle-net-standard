/* ========================================================================
 * Copyright (c) 2005-2019 The OPC Foundation, Inc. All rights reserved.
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
using Technosoftware.WorkshopServerConsole.Engineering;
using Technosoftware.WorkshopServerConsole.Operations;

namespace Technosoftware.WorkshopServerConsole.Model
{
    #region MachineInfoState Class
    #if (!OPCUA_EXCLUDE_MachineInfoState)
    /// <summary>
    /// Stores an instance of the MachineInfoType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineInfoState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MachineInfoState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Technosoftware.WorkshopServerConsole.Model.ObjectTypes.MachineInfoType, Technosoftware.WorkshopServerConsole.Model.Namespaces.WorkshopServerConsole, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
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
           "AwAAADsAAABodHRwOi8vdGVjaG5vc29mdHdhcmUuY29tL1dvcmtzaG9wU2VydmVyQ29uc29sZS9Fbmdp" +
           "bmVlcmluZzoAAABodHRwOi8vdGVjaG5vc29mdHdhcmUuY29tL1dvcmtzaG9wU2VydmVyQ29uc29sZS9P" +
           "cGVyYXRpb25zNQAAAGh0dHA6Ly90ZWNobm9zb2Z0d2FyZS5jb20vV29ya3Nob3BTZXJ2ZXJDb25zb2xl" +
           "L01vZGVs/////wRggAIBAAAAAwAXAAAATWFjaGluZUluZm9UeXBlSW5zdGFuY2UBAzo7AQM6Ozo7AAD/" +
           "////BQAAABVgiQoCAAAAAwALAAAATWFjaGluZU5hbWUBAzw7AC4ARDw7AAAADP////8BAf////8AAAAA" +
           "FWCJCgIAAAADAAwAAABNYW51ZmFjdHVyZXIBA8g6AC4ARMg6AAAADP////8BAf////8AAAAAFWCJCgIA" +
           "AAADAAwAAABTZXJpYWxOdW1iZXIBA8k6AC4ARMk6AAAADP////8BAf////8AAAAAFWCJCgIAAAADAAsA" +
           "AABJc1Byb2R1Y2luZwEDPjsALgBEPjsAAAAB/////wMD/////wAAAAAVYIkKAgAAAAMADAAAAE1hY2hp" +
           "bmVTdGF0ZQEDPzsALgBEPzsAAAAH/////wMD/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public PropertyState<string> MachineName
        {
            get
            {
                return m_machineName;
            }

            set
            {
                if (!Object.ReferenceEquals(m_machineName, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_machineName = value;
            }
        }

        /// <remarks />
        public PropertyState<string> Manufacturer
        {
            get
            {
                return m_manufacturer;
            }

            set
            {
                if (!Object.ReferenceEquals(m_manufacturer, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_manufacturer = value;
            }
        }

        /// <remarks />
        public PropertyState<string> SerialNumber
        {
            get
            {
                return m_serialNumber;
            }

            set
            {
                if (!Object.ReferenceEquals(m_serialNumber, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_serialNumber = value;
            }
        }

        /// <remarks />
        public PropertyState<bool> IsProducing
        {
            get
            {
                return m_isProducing;
            }

            set
            {
                if (!Object.ReferenceEquals(m_isProducing, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_isProducing = value;
            }
        }

        /// <remarks />
        public PropertyState<uint> MachineState
        {
            get
            {
                return m_machineState;
            }

            set
            {
                if (!Object.ReferenceEquals(m_machineState, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_machineState = value;
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
            if (m_machineName != null)
            {
                children.Add(m_machineName);
            }

            if (m_manufacturer != null)
            {
                children.Add(m_manufacturer);
            }

            if (m_serialNumber != null)
            {
                children.Add(m_serialNumber);
            }

            if (m_isProducing != null)
            {
                children.Add(m_isProducing);
            }

            if (m_machineState != null)
            {
                children.Add(m_machineState);
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
                case Technosoftware.WorkshopServerConsole.Model.BrowseNames.MachineName:
                {
                    if (createOrReplace)
                    {
                        if (MachineName == null)
                        {
                            if (replacement == null)
                            {
                                MachineName = new PropertyState<string>(this);
                            }
                            else
                            {
                                MachineName = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = MachineName;
                    break;
                }

                case Technosoftware.WorkshopServerConsole.Model.BrowseNames.Manufacturer:
                {
                    if (createOrReplace)
                    {
                        if (Manufacturer == null)
                        {
                            if (replacement == null)
                            {
                                Manufacturer = new PropertyState<string>(this);
                            }
                            else
                            {
                                Manufacturer = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = Manufacturer;
                    break;
                }

                case Technosoftware.WorkshopServerConsole.Model.BrowseNames.SerialNumber:
                {
                    if (createOrReplace)
                    {
                        if (SerialNumber == null)
                        {
                            if (replacement == null)
                            {
                                SerialNumber = new PropertyState<string>(this);
                            }
                            else
                            {
                                SerialNumber = (PropertyState<string>)replacement;
                            }
                        }
                    }

                    instance = SerialNumber;
                    break;
                }

                case Technosoftware.WorkshopServerConsole.Model.BrowseNames.IsProducing:
                {
                    if (createOrReplace)
                    {
                        if (IsProducing == null)
                        {
                            if (replacement == null)
                            {
                                IsProducing = new PropertyState<bool>(this);
                            }
                            else
                            {
                                IsProducing = (PropertyState<bool>)replacement;
                            }
                        }
                    }

                    instance = IsProducing;
                    break;
                }

                case Technosoftware.WorkshopServerConsole.Model.BrowseNames.MachineState:
                {
                    if (createOrReplace)
                    {
                        if (MachineState == null)
                        {
                            if (replacement == null)
                            {
                                MachineState = new PropertyState<uint>(this);
                            }
                            else
                            {
                                MachineState = (PropertyState<uint>)replacement;
                            }
                        }
                    }

                    instance = MachineState;
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
        private PropertyState<string> m_machineName;
        private PropertyState<string> m_manufacturer;
        private PropertyState<string> m_serialNumber;
        private PropertyState<bool> m_isProducing;
        private PropertyState<uint> m_machineState;
        #endregion
    }
    #endif
    #endregion

    #region GenericControllerState Class
    #if (!OPCUA_EXCLUDE_GenericControllerState)
    /// <summary>
    /// Stores an instance of the GenericControllerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class GenericControllerState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public GenericControllerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Technosoftware.WorkshopServerConsole.Model.ObjectTypes.GenericControllerType, Technosoftware.WorkshopServerConsole.Model.Namespaces.WorkshopServerConsole, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
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
           "AwAAADsAAABodHRwOi8vdGVjaG5vc29mdHdhcmUuY29tL1dvcmtzaG9wU2VydmVyQ29uc29sZS9Fbmdp" +
           "bmVlcmluZzoAAABodHRwOi8vdGVjaG5vc29mdHdhcmUuY29tL1dvcmtzaG9wU2VydmVyQ29uc29sZS9P" +
           "cGVyYXRpb25zNQAAAGh0dHA6Ly90ZWNobm9zb2Z0d2FyZS5jb20vV29ya3Nob3BTZXJ2ZXJDb25zb2xl" +
           "L01vZGVs/////wRggAIBAAAAAwAdAAAAR2VuZXJpY0NvbnRyb2xsZXJUeXBlSW5zdGFuY2UBA5s6AQOb" +
           "Ops6AAD/////AgAAABVgiQoCAAAAAwAIAAAAU2V0UG9pbnQBA546AC8BAEAJnjoAAAAL/////wMD////" +
           "/wEAAAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBA6I6AC4ARKI6AAABAHQD/////wEB/////wAAAAAVYIkK" +
           "AgAAAAMACwAAAE1lYXN1cmVtZW50AQOkOgAvAQBACaQ6AAAAC/////8BAf////8BAAAAFWCJCgIAAAAA" +
           "AAcAAABFVVJhbmdlAQOoOgAuAESoOgAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public AnalogItemState<double> SetPoint
        {
            get
            {
                return m_setPoint;
            }

            set
            {
                if (!Object.ReferenceEquals(m_setPoint, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_setPoint = value;
            }
        }

        /// <remarks />
        public AnalogItemState<double> Measurement
        {
            get
            {
                return m_measurement;
            }

            set
            {
                if (!Object.ReferenceEquals(m_measurement, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_measurement = value;
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
            if (m_setPoint != null)
            {
                children.Add(m_setPoint);
            }

            if (m_measurement != null)
            {
                children.Add(m_measurement);
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
                case Technosoftware.WorkshopServerConsole.Model.BrowseNames.SetPoint:
                {
                    if (createOrReplace)
                    {
                        if (SetPoint == null)
                        {
                            if (replacement == null)
                            {
                                SetPoint = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                SetPoint = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = SetPoint;
                    break;
                }

                case Technosoftware.WorkshopServerConsole.Model.BrowseNames.Measurement:
                {
                    if (createOrReplace)
                    {
                        if (Measurement == null)
                        {
                            if (replacement == null)
                            {
                                Measurement = new AnalogItemState<double>(this);
                            }
                            else
                            {
                                Measurement = (AnalogItemState<double>)replacement;
                            }
                        }
                    }

                    instance = Measurement;
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
        private AnalogItemState<double> m_setPoint;
        private AnalogItemState<double> m_measurement;
        #endregion
    }
    #endif
    #endregion

    #region FlowControllerState Class
    #if (!OPCUA_EXCLUDE_FlowControllerState)
    /// <summary>
    /// Stores an instance of the FlowControllerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class FlowControllerState : GenericControllerState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public FlowControllerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Technosoftware.WorkshopServerConsole.Model.ObjectTypes.FlowControllerType, Technosoftware.WorkshopServerConsole.Model.Namespaces.WorkshopServerConsole, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
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
           "AwAAADsAAABodHRwOi8vdGVjaG5vc29mdHdhcmUuY29tL1dvcmtzaG9wU2VydmVyQ29uc29sZS9Fbmdp" +
           "bmVlcmluZzoAAABodHRwOi8vdGVjaG5vc29mdHdhcmUuY29tL1dvcmtzaG9wU2VydmVyQ29uc29sZS9P" +
           "cGVyYXRpb25zNQAAAGh0dHA6Ly90ZWNobm9zb2Z0d2FyZS5jb20vV29ya3Nob3BTZXJ2ZXJDb25zb2xl" +
           "L01vZGVs/////wRggAIBAAAAAwAaAAAARmxvd0NvbnRyb2xsZXJUeXBlSW5zdGFuY2UBA6o6AQOqOqo6" +
           "AAD/////AgAAABVgiQoCAAAAAwAIAAAAU2V0UG9pbnQBA606AC8BAEAJrToAAAAL/////wMD/////wEA" +
           "AAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBA7E6AC4ARLE6AAABAHQD/////wEB/////wAAAAAVYIkKAgAA" +
           "AAMACwAAAE1lYXN1cmVtZW50AQOzOgAvAQBACbM6AAAAC/////8BAf////8BAAAAFWCJCgIAAAAAAAcA" +
           "AABFVVJhbmdlAQO3OgAuAES3OgAAAQB0A/////8BAf////8AAAAA";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region LevelControllerState Class
    #if (!OPCUA_EXCLUDE_LevelControllerState)
    /// <summary>
    /// Stores an instance of the LevelControllerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class LevelControllerState : GenericControllerState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public LevelControllerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Technosoftware.WorkshopServerConsole.Model.ObjectTypes.LevelControllerType, Technosoftware.WorkshopServerConsole.Model.Namespaces.WorkshopServerConsole, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
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
           "AwAAADsAAABodHRwOi8vdGVjaG5vc29mdHdhcmUuY29tL1dvcmtzaG9wU2VydmVyQ29uc29sZS9Fbmdp" +
           "bmVlcmluZzoAAABodHRwOi8vdGVjaG5vc29mdHdhcmUuY29tL1dvcmtzaG9wU2VydmVyQ29uc29sZS9P" +
           "cGVyYXRpb25zNQAAAGh0dHA6Ly90ZWNobm9zb2Z0d2FyZS5jb20vV29ya3Nob3BTZXJ2ZXJDb25zb2xl" +
           "L01vZGVs/////wRggAIBAAAAAwAbAAAATGV2ZWxDb250cm9sbGVyVHlwZUluc3RhbmNlAQO5OgEDuTq5" +
           "OgAA/////wIAAAAVYIkKAgAAAAMACAAAAFNldFBvaW50AQO8OgAvAQBACbw6AAAAC/////8DA/////8B" +
           "AAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQPAOgAuAETAOgAAAQB0A/////8BAf////8AAAAAFWCJCgIA" +
           "AAADAAsAAABNZWFzdXJlbWVudAEDwjoALwEAQAnCOgAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAH" +
           "AAAARVVSYW5nZQEDxjoALgBExjoAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region TemperatureControllerState Class
    #if (!OPCUA_EXCLUDE_TemperatureControllerState)
    /// <summary>
    /// Stores an instance of the TemperatureControllerType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class TemperatureControllerState : GenericControllerState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public TemperatureControllerState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Technosoftware.WorkshopServerConsole.Model.ObjectTypes.TemperatureControllerType, Technosoftware.WorkshopServerConsole.Model.Namespaces.WorkshopServerConsole, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
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
           "AwAAADsAAABodHRwOi8vdGVjaG5vc29mdHdhcmUuY29tL1dvcmtzaG9wU2VydmVyQ29uc29sZS9Fbmdp" +
           "bmVlcmluZzoAAABodHRwOi8vdGVjaG5vc29mdHdhcmUuY29tL1dvcmtzaG9wU2VydmVyQ29uc29sZS9P" +
           "cGVyYXRpb25zNQAAAGh0dHA6Ly90ZWNobm9zb2Z0d2FyZS5jb20vV29ya3Nob3BTZXJ2ZXJDb25zb2xl" +
           "L01vZGVs/////wRggAIBAAAAAwAhAAAAVGVtcGVyYXR1cmVDb250cm9sbGVyVHlwZUluc3RhbmNlAQPK" +
           "OgEDyjrKOgAA/////wIAAAAVYIkKAgAAAAMACAAAAFNldFBvaW50AQPLOgAvAQBACcs6AAAAC/////8D" +
           "A/////8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQPPOgAuAETPOgAAAQB0A/////8BAf////8AAAAA" +
           "FWCJCgIAAAADAAsAAABNZWFzdXJlbWVudAED0ToALwEAQAnROgAAAAv/////AQH/////AQAAABVgiQoC" +
           "AAAAAAAHAAAARVVSYW5nZQED1ToALgBE1ToAAAEAdAP/////AQH/////AAAAAA==";
        #endregion
        #endif
        #endregion

        #region Public Properties
        #endregion

        #region Overridden Methods
        #endregion

        #region Private Fields
        #endregion
    }
    #endif
    #endregion

    #region MachineState Class
    #if (!OPCUA_EXCLUDE_MachineState)
    /// <summary>
    /// Stores an instance of the MachineType ObjectType.
    /// </summary>
    /// <exclude />
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Opc.Ua.ModelCompiler", "1.0.0.0")]
    public partial class MachineState : BaseObjectState
    {
        #region Constructors
        /// <summary>
        /// Initializes the type with its default attribute values.
        /// </summary>
        public MachineState(NodeState parent) : base(parent)
        {
        }

        /// <summary>
        /// Returns the id of the default type definition node for the instance.
        /// </summary>
        protected override NodeId GetDefaultTypeDefinitionId(NamespaceTable namespaceUris)
        {
            return Opc.Ua.NodeId.Create(Technosoftware.WorkshopServerConsole.Model.ObjectTypes.MachineType, Technosoftware.WorkshopServerConsole.Model.Namespaces.WorkshopServerConsole, namespaceUris);
        }

        #if (!OPCUA_EXCLUDE_InitializationStrings)
        /// <summary>
        /// Initializes the instance.
        /// </summary>
        protected override void Initialize(ISystemContext context)
        {
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
           "AwAAADsAAABodHRwOi8vdGVjaG5vc29mdHdhcmUuY29tL1dvcmtzaG9wU2VydmVyQ29uc29sZS9Fbmdp" +
           "bmVlcmluZzoAAABodHRwOi8vdGVjaG5vc29mdHdhcmUuY29tL1dvcmtzaG9wU2VydmVyQ29uc29sZS9P" +
           "cGVyYXRpb25zNQAAAGh0dHA6Ly90ZWNobm9zb2Z0d2FyZS5jb20vV29ya3Nob3BTZXJ2ZXJDb25zb2xl" +
           "L01vZGVs/////wRggAIBAAAAAwATAAAATWFjaGluZVR5cGVJbnN0YW5jZQED+ToBA/k6+ToAAP////8E" +
           "AAAABGCACgEAAAADAAsAAABNYWNoaW5lSW5mbwED+joALwEDOjv6OgAA/////wUAAAAVYIkKAgAAAAMA" +
           "CwAAAE1hY2hpbmVOYW1lAQP7OgAuAET7OgAAAAz/////AQH/////AAAAABVgiQoCAAAAAwAMAAAATWFu" +
           "dWZhY3R1cmVyAQPXOgAuAETXOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAwAMAAAAU2VyaWFsTnVt" +
           "YmVyAQPYOgAuAETYOgAAAAz/////AQH/////AAAAABVgiQoCAAAAAwALAAAASXNQcm9kdWNpbmcBA/w6" +
           "AC4ARPw6AAAAAf////8DA/////8AAAAAFWCJCgIAAAADAAwAAABNYWNoaW5lU3RhdGUBA/06AC4ARP06" +
           "AAAAB/////8DA/////8AAAAABGCACgEAAAADAAsAAABUZW1wZXJhdHVyZQED2ToALwEDyjrZOgAA////" +
           "/wIAAAAVYIkKAgAAAAMACAAAAFNldFBvaW50AQPaOgAvAQBACdo6AAAAC/////8DA/////8BAAAAFWCJ" +
           "CgIAAAAAAAcAAABFVVJhbmdlAQPeOgAuAETeOgAAAQB0A/////8BAf////8AAAAAFWCJCgIAAAADAAsA" +
           "AABNZWFzdXJlbWVudAED4DoALwEAQAngOgAAAAv/////AQH/////AQAAABVgiQoCAAAAAAAHAAAARVVS" +
           "YW5nZQED5DoALgBE5DoAAAEAdAP/////AQH/////AAAAAARggAoBAAAAAwAEAAAARmxvdwED5joALwED" +
           "qjrmOgAA/////wIAAAAVYIkKAgAAAAMACAAAAFNldFBvaW50AQPnOgAvAQBACec6AAAAC/////8DA///" +
           "//8BAAAAFWCJCgIAAAAAAAcAAABFVVJhbmdlAQPrOgAuAETrOgAAAQB0A/////8BAf////8AAAAAFWCJ" +
           "CgIAAAADAAsAAABNZWFzdXJlbWVudAED7ToALwEAQAntOgAAAAv/////AQH/////AQAAABVgiQoCAAAA" +
           "AAAHAAAARVVSYW5nZQED8ToALgBE8ToAAAEAdAP/////AQH/////AAAAAARggAoBAAAAAwAFAAAATGV2" +
           "ZWwBA/M6AC8BA7k68zoAAP////8CAAAAFWCJCgIAAAADAAgAAABTZXRQb2ludAED9DoALwEAQAn0OgAA" +
           "AAv/////AwP/////AQAAABVgiQoCAAAAAAAHAAAARVVSYW5nZQED+DoALgBE+DoAAAEAdAP/////AQH/" +
           "////AAAAABVgiQoCAAAAAwALAAAATWVhc3VyZW1lbnQBAy87AC8BAEAJLzsAAAAL/////wEB/////wEA" +
           "AAAVYIkKAgAAAAAABwAAAEVVUmFuZ2UBAzM7AC4ARDM7AAABAHQD/////wEB/////wAAAAA=";
        #endregion
        #endif
        #endregion

        #region Public Properties
        /// <remarks />
        public MachineInfoState MachineInfo
        {
            get
            {
                return m_machineInfo;
            }

            set
            {
                if (!Object.ReferenceEquals(m_machineInfo, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_machineInfo = value;
            }
        }

        /// <remarks />
        public TemperatureControllerState Temperature
        {
            get
            {
                return m_temperature;
            }

            set
            {
                if (!Object.ReferenceEquals(m_temperature, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_temperature = value;
            }
        }

        /// <remarks />
        public FlowControllerState Flow
        {
            get
            {
                return m_flow;
            }

            set
            {
                if (!Object.ReferenceEquals(m_flow, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_flow = value;
            }
        }

        /// <remarks />
        public LevelControllerState Level
        {
            get
            {
                return m_level;
            }

            set
            {
                if (!Object.ReferenceEquals(m_level, value))
                {
                    ChangeMasks |= NodeStateChangeMasks.Children;
                }

                m_level = value;
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
            if (m_machineInfo != null)
            {
                children.Add(m_machineInfo);
            }

            if (m_temperature != null)
            {
                children.Add(m_temperature);
            }

            if (m_flow != null)
            {
                children.Add(m_flow);
            }

            if (m_level != null)
            {
                children.Add(m_level);
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
                case Technosoftware.WorkshopServerConsole.Model.BrowseNames.MachineInfo:
                {
                    if (createOrReplace)
                    {
                        if (MachineInfo == null)
                        {
                            if (replacement == null)
                            {
                                MachineInfo = new MachineInfoState(this);
                            }
                            else
                            {
                                MachineInfo = (MachineInfoState)replacement;
                            }
                        }
                    }

                    instance = MachineInfo;
                    break;
                }

                case Technosoftware.WorkshopServerConsole.Model.BrowseNames.Temperature:
                {
                    if (createOrReplace)
                    {
                        if (Temperature == null)
                        {
                            if (replacement == null)
                            {
                                Temperature = new TemperatureControllerState(this);
                            }
                            else
                            {
                                Temperature = (TemperatureControllerState)replacement;
                            }
                        }
                    }

                    instance = Temperature;
                    break;
                }

                case Technosoftware.WorkshopServerConsole.Model.BrowseNames.Flow:
                {
                    if (createOrReplace)
                    {
                        if (Flow == null)
                        {
                            if (replacement == null)
                            {
                                Flow = new FlowControllerState(this);
                            }
                            else
                            {
                                Flow = (FlowControllerState)replacement;
                            }
                        }
                    }

                    instance = Flow;
                    break;
                }

                case Technosoftware.WorkshopServerConsole.Model.BrowseNames.Level:
                {
                    if (createOrReplace)
                    {
                        if (Level == null)
                        {
                            if (replacement == null)
                            {
                                Level = new LevelControllerState(this);
                            }
                            else
                            {
                                Level = (LevelControllerState)replacement;
                            }
                        }
                    }

                    instance = Level;
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
        private MachineInfoState m_machineInfo;
        private TemperatureControllerState m_temperature;
        private FlowControllerState m_flow;
        private LevelControllerState m_level;
        #endregion
    }
    #endif
    #endregion
}