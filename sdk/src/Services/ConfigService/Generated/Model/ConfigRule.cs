/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// An AWS Lambda function that evaluates configuration items to assess whether your AWS
    /// resources comply with your desired configurations. This function can run when AWS
    /// Config detects a configuration change to an AWS resource, or when it delivers a configuration
    /// snapshot of the resources in the account.
    /// 
    ///  
    /// <para>
    /// For more information about developing and using AWS Config rules, see <a href="http://docs.aws.amazon.com/config/latest/developerguide/evaluate-config.html">Evaluating
    /// AWS Resource Configurations with AWS Config</a> in the <i>AWS Config Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ConfigRule
    {
        private string _configRuleArn;
        private string _configRuleId;
        private string _configRuleName;
        private ConfigRuleState _configRuleState;
        private string _description;
        private string _inputParameters;
        private MaximumExecutionFrequency _maximumExecutionFrequency;
        private Scope _scope;
        private Source _source;

        /// <summary>
        /// Gets and sets the property ConfigRuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Config rule.
        /// </para>
        /// </summary>
        public string ConfigRuleArn
        {
            get { return this._configRuleArn; }
            set { this._configRuleArn = value; }
        }

        // Check to see if ConfigRuleArn property is set
        internal bool IsSetConfigRuleArn()
        {
            return this._configRuleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigRuleId. 
        /// <para>
        /// The ID of the AWS Config rule.
        /// </para>
        /// </summary>
        public string ConfigRuleId
        {
            get { return this._configRuleId; }
            set { this._configRuleId = value; }
        }

        // Check to see if ConfigRuleId property is set
        internal bool IsSetConfigRuleId()
        {
            return this._configRuleId != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigRuleName. 
        /// <para>
        /// The name that you assign to the AWS Config rule. The name is required if you are adding
        /// a new rule.
        /// </para>
        /// </summary>
        public string ConfigRuleName
        {
            get { return this._configRuleName; }
            set { this._configRuleName = value; }
        }

        // Check to see if ConfigRuleName property is set
        internal bool IsSetConfigRuleName()
        {
            return this._configRuleName != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigRuleState. 
        /// <para>
        /// Indicates whether the AWS Config rule is active or currently being deleted by AWS
        /// Config.
        /// </para>
        ///  
        /// <para>
        /// AWS Config sets the state of a rule to <code>DELETING</code> temporarily after you
        /// use the <code>DeleteConfigRule</code> request to delete the rule. After AWS Config
        /// finishes deleting a rule, the rule and all of its evaluations are erased and no longer
        /// available.
        /// </para>
        ///  
        /// <para>
        /// You cannot add a rule to AWS Config that has the state set to <code>DELETING</code>.
        /// If you want to delete a rule, you must use the <code>DeleteConfigRule</code> request.
        /// </para>
        /// </summary>
        public ConfigRuleState ConfigRuleState
        {
            get { return this._configRuleState; }
            set { this._configRuleState = value; }
        }

        // Check to see if ConfigRuleState property is set
        internal bool IsSetConfigRuleState()
        {
            return this._configRuleState != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description that you provide for the AWS Config rule.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property InputParameters. 
        /// <para>
        /// A string in JSON format that is passed to the AWS Config rule Lambda function.
        /// </para>
        /// </summary>
        public string InputParameters
        {
            get { return this._inputParameters; }
            set { this._inputParameters = value; }
        }

        // Check to see if InputParameters property is set
        internal bool IsSetInputParameters()
        {
            return this._inputParameters != null;
        }

        /// <summary>
        /// Gets and sets the property MaximumExecutionFrequency. 
        /// <para>
        /// The maximum frequency at which the AWS Config rule runs evaluations.
        /// </para>
        ///  
        /// <para>
        /// If your rule is periodic, meaning it runs an evaluation when AWS Config delivers a
        /// configuration snapshot, then it cannot run evaluations more frequently than AWS Config
        /// delivers the snapshots. For periodic rules, set the value of the <code>MaximumExecutionFrequency</code>
        /// key to be equal to or greater than the value of the <code>deliveryFrequency</code>
        /// key, which is part of <code>ConfigSnapshotDeliveryProperties</code>. To update the
        /// frequency with which AWS Config delivers your snapshots, use the <code>PutDeliveryChannel</code>
        /// action.
        /// </para>
        /// </summary>
        public MaximumExecutionFrequency MaximumExecutionFrequency
        {
            get { return this._maximumExecutionFrequency; }
            set { this._maximumExecutionFrequency = value; }
        }

        // Check to see if MaximumExecutionFrequency property is set
        internal bool IsSetMaximumExecutionFrequency()
        {
            return this._maximumExecutionFrequency != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Defines which resources can trigger an evaluation for the rule. The scope can include
        /// one or more resource types, a combination of one resource type and one resource ID,
        /// or a combination of a tag key and value. Specify a scope to constrain the resources
        /// that can trigger an evaluation for the rule. If you do not specify a scope, evaluations
        /// are triggered when any resource in the recording group changes.
        /// </para>
        /// </summary>
        public Scope Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Provides the rule owner (AWS or customer), the rule identifier, and the events that
        /// cause the function to evaluate your AWS resources.
        /// </para>
        /// </summary>
        public Source Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}