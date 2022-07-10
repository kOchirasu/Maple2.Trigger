namespace Maple2.Trigger._61000008_me {
    public static class _g07p00_700 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{110, 111, 112, 113, 114, 115}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{120, 121, 122, 123, 124, 125}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{130, 131, 132, 133, 134, 135}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{140, 141, 142, 143, 144, 145}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{210, 211, 212, 213, 214, 215}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{220, 221, 222, 223, 224, 225}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{230, 231, 232, 233, 234, 235}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{240, 241, 242, 243, 244, 245}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{310, 311, 312, 313, 314, 315}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{320, 321, 322, 323, 324, 325}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{330, 331, 332, 333, 334, 335}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{340, 341, 342, 343, 344, 345}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{410, 411, 412, 413, 414, 415}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{420, 421, 422, 423, 424, 425}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{430, 431, 432, 433, 434, 435}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{440, 441, 442, 443, 444, 445}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{2207, 2208, 2209, 22000, 22005, 22010, 22020, 22030}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{2307, 2308, 2309, 23000, 23005, 23010, 23020, 23030}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{3207, 3208, 3209, 32000, 32005, 32010, 32020, 32030}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new int[]{3307, 3308, 3309, 33000, 33005, 33010, 33020, 33030}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P201Set") == 1) {
                    return new StateNumberOnP201(context);
                }

                if (context.GetUserValue(key: "G07P202Set") == 1) {
                    return new StateNumberOnP202(context);
                }

                if (context.GetUserValue(key: "G07P203Set") == 1) {
                    return new StateNumberOnP203(context);
                }

                if (context.GetUserValue(key: "G07P204Set") == 1) {
                    return new StateNumberOnP204(context);
                }

                if (context.GetUserValue(key: "G07P205Set") == 1) {
                    return new StateNumberOnP205(context);
                }

                if (context.GetUserValue(key: "G07P206Set") == 1) {
                    return new StateNumberOnP206(context);
                }

                if (context.GetUserValue(key: "G07P207Set") == 1) {
                    return new StateNumberOnP207(context);
                }

                if (context.GetUserValue(key: "G07P208Set") == 1) {
                    return new StateNumberOnP208(context);
                }

                if (context.GetUserValue(key: "G07P209Set") == 1) {
                    return new StateNumberOnP209(context);
                }

                if (context.GetUserValue(key: "G07P210Set") == 1) {
                    return new StateNumberOnP210(context);
                }

                if (context.GetUserValue(key: "G07P301Set") == 1) {
                    return new StateNumberOnP301(context);
                }

                if (context.GetUserValue(key: "G07P302Set") == 1) {
                    return new StateNumberOnP302(context);
                }

                if (context.GetUserValue(key: "G07P303Set") == 1) {
                    return new StateNumberOnP303(context);
                }

                if (context.GetUserValue(key: "G07P304Set") == 1) {
                    return new StateNumberOnP304(context);
                }

                if (context.GetUserValue(key: "G07P305Set") == 1) {
                    return new StateNumberOnP305(context);
                }

                if (context.GetUserValue(key: "G07P306Set") == 1) {
                    return new StateNumberOnP306(context);
                }

                if (context.GetUserValue(key: "G07P307Set") == 1) {
                    return new StateNumberOnP307(context);
                }

                if (context.GetUserValue(key: "G07P308Set") == 1) {
                    return new StateNumberOnP308(context);
                }

                if (context.GetUserValue(key: "G07P309Set") == 1) {
                    return new StateNumberOnP309(context);
                }

                if (context.GetUserValue(key: "G07P310Set") == 1) {
                    return new StateNumberOnP310(context);
                }

                if (context.GetUserValue(key: "G07P401Set") == 1) {
                    return new StateNumberOnP401(context);
                }

                if (context.GetUserValue(key: "G07P402Set") == 1) {
                    return new StateNumberOnP402(context);
                }

                if (context.GetUserValue(key: "G07P403Set") == 1) {
                    return new StateNumberOnP403(context);
                }

                if (context.GetUserValue(key: "G07P404Set") == 1) {
                    return new StateNumberOnP404(context);
                }

                if (context.GetUserValue(key: "G07P405Set") == 1) {
                    return new StateNumberOnP405(context);
                }

                if (context.GetUserValue(key: "G07P406Set") == 1) {
                    return new StateNumberOnP406(context);
                }

                if (context.GetUserValue(key: "G07P407Set") == 1) {
                    return new StateNumberOnP407(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP201 : TriggerState {
            internal StateNumberOnP201(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{110}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{120}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{132}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{142}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{215}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22010}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22005}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{233}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{244}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{314}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{322}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{335}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{413}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{430}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{440}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 0);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 0);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 15);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 0);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P201TimeLimit") == 1) {
                    return new StateCheckP201(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP201 : TriggerState {
            internal StateCheckP201(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 0);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 0);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 15);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 0);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 0);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP201(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP201 : TriggerState {
            internal StateNumberOffP201(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{110}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{120}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{132}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{142}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{215}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22010}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22005}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{233}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{244}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{314}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{322}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{335}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{413}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{430}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{440}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP201(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP201 : TriggerState {
            internal StateResetP201(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P201End", value: 1);
                context.SetUserValue(key: "G07P201Set", value: 0);
                context.SetUserValue(key: "G07P201TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP202 : TriggerState {
            internal StateNumberOnP202(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{112}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{122}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{210}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{222}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23010}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23005}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{322}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{332}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{410}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{432}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 0);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 15);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 0);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P202TimeLimit") == 1) {
                    return new StateCheckP202(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP202 : TriggerState {
            internal StateCheckP202(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 0);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 15);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 0);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP202(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP202 : TriggerState {
            internal StateNumberOffP202(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{112}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{122}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{210}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{222}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23010}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23005}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{322}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{332}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{410}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{432}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP202(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP202 : TriggerState {
            internal StateResetP202(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P202End", value: 1);
                context.SetUserValue(key: "G07P202Set", value: 0);
                context.SetUserValue(key: "G07P202TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP203 : TriggerState {
            internal StateNumberOnP203(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{112}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{124}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{130}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{210}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{222}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{234}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{240}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32010}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32005}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{332}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{344}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{412}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{430}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 0);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 0);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 0);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 15);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 0);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P203TimeLimit") == 1) {
                    return new StateCheckP203(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP203 : TriggerState {
            internal StateCheckP203(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 0);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 0);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 0);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 15);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 0);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP203(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP203 : TriggerState {
            internal StateNumberOffP203(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{112}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{124}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{130}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{210}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{222}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{234}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{240}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32010}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32005}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{332}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{344}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{412}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{430}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP203(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP203 : TriggerState {
            internal StateResetP203(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P203End", value: 1);
                context.SetUserValue(key: "G07P203Set", value: 0);
                context.SetUserValue(key: "G07P203TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP204 : TriggerState {
            internal StateNumberOnP204(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{114}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{120}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{140}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{212}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{225}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{235}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{240}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{325}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33010}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33005}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{342}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{412}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{430}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{444}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 0);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 0);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 0);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 15);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 0);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 4);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P204TimeLimit") == 1) {
                    return new StateCheckP204(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP204 : TriggerState {
            internal StateCheckP204(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 0);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 0);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 0);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 15);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 0);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 4);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP204(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP204 : TriggerState {
            internal StateNumberOffP204(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{114}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{120}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{140}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{212}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{225}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{235}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{240}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{325}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33010}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33005}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{342}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{412}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{430}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{444}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP204(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP204 : TriggerState {
            internal StateResetP204(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P204End", value: 1);
                context.SetUserValue(key: "G07P204Set", value: 0);
                context.SetUserValue(key: "G07P204TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP205 : TriggerState {
            internal StateNumberOnP205(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{120}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{134}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{212}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22000}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{232}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{323}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{330}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{342}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{413}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{420}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{434}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{442}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 0);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 20);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 0);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 0);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P205TimeLimit") == 1) {
                    return new StateCheckP205(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP205 : TriggerState {
            internal StateCheckP205(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 0);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 20);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 0);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 0);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP205(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP205 : TriggerState {
            internal StateNumberOffP205(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{120}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{134}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{212}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22000}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{232}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{323}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{330}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{342}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{413}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{420}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{434}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{442}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP205(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP205 : TriggerState {
            internal StateResetP205(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P205End", value: 1);
                context.SetUserValue(key: "G07P205Set", value: 0);
                context.SetUserValue(key: "G07P205TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP206 : TriggerState {
            internal StateNumberOnP206(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{111}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{123}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{132}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{141}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{213}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{225}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23000}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{310}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{323}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{335}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{340}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{411}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{425}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{442}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 1);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 20);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 0);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 0);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 1);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P206TimeLimit") == 1) {
                    return new StateCheckP206(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP206 : TriggerState {
            internal StateCheckP206(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 1);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 20);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 0);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 0);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 1);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP206(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP206 : TriggerState {
            internal StateNumberOffP206(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{111}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{123}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{132}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{141}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{213}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{225}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23000}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{310}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{323}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{335}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{340}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{411}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{425}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{442}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP206(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP206 : TriggerState {
            internal StateResetP206(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P206End", value: 1);
                context.SetUserValue(key: "G07P206Set", value: 0);
                context.SetUserValue(key: "G07P206TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP207 : TriggerState {
            internal StateNumberOnP207(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{110}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{122}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{131}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{145}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{210}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{221}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{233}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{242}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{315}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32000}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{333}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{414}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{422}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{431}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{440}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 0);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 0);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 1);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 20);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P207TimeLimit") == 1) {
                    return new StateCheckP207(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP207 : TriggerState {
            internal StateCheckP207(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 0);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 0);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 1);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 20);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 0);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP207(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP207 : TriggerState {
            internal StateNumberOffP207(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{110}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{122}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{131}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{145}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{210}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{221}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{233}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{242}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{315}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32000}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{333}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{414}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{422}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{431}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{440}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP207(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP207 : TriggerState {
            internal StateResetP207(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P207End", value: 1);
                context.SetUserValue(key: "G07P207Set", value: 0);
                context.SetUserValue(key: "G07P207TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP208 : TriggerState {
            internal StateNumberOnP208(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{121}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{132}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{144}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{214}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{223}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{231}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{242}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{312}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{324}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33000}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{341}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{413}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{422}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{441}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 1);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 1);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 4);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 20);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 1);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P208TimeLimit") == 1) {
                    return new StateCheckP208(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP208 : TriggerState {
            internal StateCheckP208(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 1);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 1);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 4);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 20);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 1);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 1);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP208(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP208 : TriggerState {
            internal StateNumberOffP208(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{121}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{132}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{144}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{214}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{223}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{231}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{242}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{312}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{324}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33000}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{341}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{413}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{422}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{441}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP208(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP208 : TriggerState {
            internal StateResetP208(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P208End", value: 1);
                context.SetUserValue(key: "G07P208Set", value: 0);
                context.SetUserValue(key: "G07P208TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP209 : TriggerState {
            internal StateNumberOnP209(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{122}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{212}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22005}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{232}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{242}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{312}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{323}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{333}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{342}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{413}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{422}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{432}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 25);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P209TimeLimit") == 1) {
                    return new StateCheckP209(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP209 : TriggerState {
            internal StateCheckP209(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 25);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP209(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP209 : TriggerState {
            internal StateNumberOffP209(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{122}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{212}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22005}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{232}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{242}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{312}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{323}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{333}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{342}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{413}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{422}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{432}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP209(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP209 : TriggerState {
            internal StateResetP209(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P209End", value: 1);
                context.SetUserValue(key: "G07P209Set", value: 0);
                context.SetUserValue(key: "G07P209TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP210 : TriggerState {
            internal StateNumberOnP210(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{110}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{123}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{135}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{140}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{210}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{222}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{233}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{245}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{315}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{320}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33005}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{342}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{413}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{422}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{435}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{440}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 0);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 0);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 0);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 0);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 25);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P210TimeLimit") == 1) {
                    return new StateCheckP210(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP210 : TriggerState {
            internal StateCheckP210(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 0);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 0);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 0);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 0);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 25);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 0);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP210(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP210 : TriggerState {
            internal StateNumberOffP210(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{110}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{123}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{135}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{140}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{210}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{222}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{233}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{245}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{315}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{320}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33005}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{342}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{413}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{422}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{435}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{440}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP210(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP210 : TriggerState {
            internal StateResetP210(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P210End", value: 1);
                context.SetUserValue(key: "G07P210Set", value: 0);
                context.SetUserValue(key: "G07P210TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP301 : TriggerState {
            internal StateNumberOnP301(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{122}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{132}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{212}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{222}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{233}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{244}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{312}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{323}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33005}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{345}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{415}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{424}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{432}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 25);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P301TimeLimit") == 1) {
                    return new StateCheckP301(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP301 : TriggerState {
            internal StateCheckP301(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 25);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP301(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP301 : TriggerState {
            internal StateNumberOffP301(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{122}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{132}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{212}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{222}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{233}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{244}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{312}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{323}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33005}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{345}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{415}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{424}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{432}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP301(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP301 : TriggerState {
            internal StateResetP301(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P301End", value: 1);
                context.SetUserValue(key: "G07P301Set", value: 0);
                context.SetUserValue(key: "G07P301TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP302 : TriggerState {
            internal StateNumberOnP302(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{122}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{135}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{213}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{223}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23005}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{242}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{312}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{325}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{333}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{345}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{412}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{422}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{442}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 25);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P302TimeLimit") == 1) {
                    return new StateCheckP302(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP302 : TriggerState {
            internal StateCheckP302(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 25);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP302(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP302 : TriggerState {
            internal StateNumberOffP302(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{122}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{135}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{213}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{223}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23005}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{242}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{312}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{325}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{333}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{345}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{412}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{422}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{442}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP302(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP302 : TriggerState {
            internal StateResetP302(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P302End", value: 1);
                context.SetUserValue(key: "G07P302Set", value: 0);
                context.SetUserValue(key: "G07P302TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP303 : TriggerState {
            internal StateNumberOnP303(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{114}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{123}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{132}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{144}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{215}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{222}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{233}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{245}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32005}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{332}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{344}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{413}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{422}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{434}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{442}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 25);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P303TimeLimit") == 1) {
                    return new StateCheckP303(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP303 : TriggerState {
            internal StateCheckP303(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 25);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP303(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP303 : TriggerState {
            internal StateNumberOffP303(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{114}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{123}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{132}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{144}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{215}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{222}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{233}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{245}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32005}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{332}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{344}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{413}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{422}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{434}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{442}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP303(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP303 : TriggerState {
            internal StateResetP303(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P303End", value: 1);
                context.SetUserValue(key: "G07P303Set", value: 0);
                context.SetUserValue(key: "G07P303TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP304 : TriggerState {
            internal StateNumberOnP304(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{112}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{124}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{134}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{142}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{213}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22000}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{233}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{242}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{314}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{322}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{333}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{414}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{424}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{442}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 20);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 3);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 2);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P304TimeLimit") == 1) {
                    return new StateCheckP304(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP304 : TriggerState {
            internal StateCheckP304(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 20);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 3);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 2);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP304(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP304 : TriggerState {
            internal StateNumberOffP304(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{112}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{124}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{134}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{142}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{213}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22000}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{233}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{242}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{314}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{322}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{333}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{414}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{424}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{442}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP304(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP304 : TriggerState {
            internal StateResetP304(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P304End", value: 1);
                context.SetUserValue(key: "G07P304Set", value: 0);
                context.SetUserValue(key: "G07P304TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP305 : TriggerState {
            internal StateNumberOnP305(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{114}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{123}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{132}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{145}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{211}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{223}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23000}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{244}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{312}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{325}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{334}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{411}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{431}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{444}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 1);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 20);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 1);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 4);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P305TimeLimit") == 1) {
                    return new StateCheckP305(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP305 : TriggerState {
            internal StateCheckP305(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 1);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 20);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 1);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 4);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP305(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP305 : TriggerState {
            internal StateNumberOffP305(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{114}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{123}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{132}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{145}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{211}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{223}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23000}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{244}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{312}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{325}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{334}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{411}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{431}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{444}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP305(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP305 : TriggerState {
            internal StateResetP305(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P305End", value: 1);
                context.SetUserValue(key: "G07P305Set", value: 0);
                context.SetUserValue(key: "G07P305TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP306 : TriggerState {
            internal StateNumberOnP306(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{112}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{125}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{141}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{214}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{222}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{235}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{242}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{325}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33000}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{344}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{411}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{434}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{441}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 1);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 20);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 1);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P306TimeLimit") == 1) {
                    return new StateCheckP306(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP306 : TriggerState {
            internal StateCheckP306(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 1);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 20);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 1);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 1);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP306(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP306 : TriggerState {
            internal StateNumberOffP306(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{112}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{125}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{141}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{214}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{222}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{235}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{242}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{325}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33000}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{344}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{411}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{434}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{441}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP306(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP306 : TriggerState {
            internal StateResetP306(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P306End", value: 1);
                context.SetUserValue(key: "G07P306Set", value: 0);
                context.SetUserValue(key: "G07P306TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP307 : TriggerState {
            internal StateNumberOnP307(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{122}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{142}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{215}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{223}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{235}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{242}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32030}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32000}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{332}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{414}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{422}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{434}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{442}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 30);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 4);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P307TimeLimit") == 1) {
                    return new StateCheckP307(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP307 : TriggerState {
            internal StateCheckP307(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 30);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 4);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP307(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP307 : TriggerState {
            internal StateNumberOffP307(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{122}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{142}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{215}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{223}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{235}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{242}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32030}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32000}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{332}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{414}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{422}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{434}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{442}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP307(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP307 : TriggerState {
            internal StateResetP307(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P307End", value: 1);
                context.SetUserValue(key: "G07P307Set", value: 0);
                context.SetUserValue(key: "G07P307TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP308 : TriggerState {
            internal StateNumberOnP308(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{115}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{124}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{131}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{213}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{222}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23030}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23000}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{311}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{325}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{332}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{342}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{412}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{424}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{431}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{445}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 1);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 30);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 1);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 2);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 1);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 5);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P308TimeLimit") == 1) {
                    return new StateCheckP308(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP308 : TriggerState {
            internal StateCheckP308(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 1);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 30);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 1);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 2);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 1);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 5);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP308(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP308 : TriggerState {
            internal StateNumberOffP308(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{115}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{124}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{131}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{213}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{222}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23030}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23000}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{311}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{325}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{332}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{342}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{412}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{424}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{431}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{445}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP308(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP308 : TriggerState {
            internal StateResetP308(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P308End", value: 1);
                context.SetUserValue(key: "G07P308Set", value: 0);
                context.SetUserValue(key: "G07P308TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP309 : TriggerState {
            internal StateNumberOnP309(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{124}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{142}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{213}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22010}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22005}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{232}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{312}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{323}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33005}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{412}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{434}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 15);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 25);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P309TimeLimit") == 1) {
                    return new StateCheckP309(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP309 : TriggerState {
            internal StateCheckP309(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 15);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 25);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP309(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP309 : TriggerState {
            internal StateNumberOffP309(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{124}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{142}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{213}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22010}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22005}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{232}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{312}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{323}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33005}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{412}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{434}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP309(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP309 : TriggerState {
            internal StateResetP309(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P309End", value: 1);
                context.SetUserValue(key: "G07P309Set", value: 0);
                context.SetUserValue(key: "G07P309TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP310 : TriggerState {
            internal StateNumberOnP310(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{112}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{123}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{142}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{213}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{224}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23000}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32000}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{334}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{412}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{442}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 3);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 2);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 20);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 20);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P310TimeLimit") == 1) {
                    return new StateCheckP310(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP310 : TriggerState {
            internal StateCheckP310(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 3);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 2);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 20);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 20);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP310(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP310 : TriggerState {
            internal StateNumberOffP310(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{112}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{123}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{142}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{213}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{224}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23000}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32000}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{334}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{412}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{442}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP310(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP310 : TriggerState {
            internal StateResetP310(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P310End", value: 1);
                context.SetUserValue(key: "G07P310Set", value: 0);
                context.SetUserValue(key: "G07P310TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP401 : TriggerState {
            internal StateNumberOnP401(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{114}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{122}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{134}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{214}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22030}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22000}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{234}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{244}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{314}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{323}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{334}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{344}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{413}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{424}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{432}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{444}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 2);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 30);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 4);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 3);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 4);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 3);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 2);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 4);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P401TimeLimit") == 1) {
                    return new StateCheckP401(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP401 : TriggerState {
            internal StateCheckP401(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 2);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 30);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 4);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 3);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 4);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 3);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 2);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 4);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP401(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP401 : TriggerState {
            internal StateNumberOffP401(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{114}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{122}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{134}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{214}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22030}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22000}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{234}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{244}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{314}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{323}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{334}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{344}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{413}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{424}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{432}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{444}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP401(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP401 : TriggerState {
            internal StateResetP401(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P401End", value: 1);
                context.SetUserValue(key: "G07P401Set", value: 0);
                context.SetUserValue(key: "G07P401TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP402 : TriggerState {
            internal StateNumberOnP402(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{112}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{125}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{145}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{212}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{224}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{232}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{245}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{325}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33030}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33000}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{415}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{434}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{445}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 4);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 30);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 4);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 5);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P402TimeLimit") == 1) {
                    return new StateCheckP402(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP402 : TriggerState {
            internal StateCheckP402(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 4);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 30);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 4);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 5);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP402(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP402 : TriggerState {
            internal StateNumberOffP402(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{112}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{125}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{145}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{212}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{224}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{232}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{245}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{325}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33030}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33000}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{415}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{434}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{445}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP402(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP402 : TriggerState {
            internal StateResetP402(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P402End", value: 1);
                context.SetUserValue(key: "G07P402Set", value: 0);
                context.SetUserValue(key: "G07P402TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP403 : TriggerState {
            internal StateNumberOnP403(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{112}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{124}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{135}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{212}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{225}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23005}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{245}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{325}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{335}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{344}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{412}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{442}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 2);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 5);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 25);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 5);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 3);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P403TimeLimit") == 1) {
                    return new StateCheckP403(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP403 : TriggerState {
            internal StateCheckP403(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 2);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 5);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 25);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 5);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 3);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP403(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP403 : TriggerState {
            internal StateNumberOffP403(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{112}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{124}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{135}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{212}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{225}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23005}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{245}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{325}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{335}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{344}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{412}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{423}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{442}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP403(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP403 : TriggerState {
            internal StateResetP403(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P403End", value: 1);
                context.SetUserValue(key: "G07P403Set", value: 0);
                context.SetUserValue(key: "G07P403TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP404 : TriggerState {
            internal StateNumberOnP404(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{115}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{125}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{132}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{145}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{215}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{223}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{232}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{312}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32005}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{333}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{345}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{412}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{422}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{435}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{443}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 5);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 2);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 5);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 2);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 2);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 25);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 5);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 2);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P404TimeLimit") == 1) {
                    return new StateCheckP404(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP404 : TriggerState {
            internal StateCheckP404(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 5);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 2);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 5);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 2);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 2);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 25);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 5);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 2);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 3);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP404(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP404 : TriggerState {
            internal StateNumberOffP404(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{115}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{125}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{132}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{145}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{215}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{223}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{232}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{312}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32005}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{333}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{345}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{412}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{422}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{435}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{443}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP404(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP404 : TriggerState {
            internal StateResetP404(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P404End", value: 1);
                context.SetUserValue(key: "G07P404Set", value: 0);
                context.SetUserValue(key: "G07P404TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP405 : TriggerState {
            internal StateNumberOnP405(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{112}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{124}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{134}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{215}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{223}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{235}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{245}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32010}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32005}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33010}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33005}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{415}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{425}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{433}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{444}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 2);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 4);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 3);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 5);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 3);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 5);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 5);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 3);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 15);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 15);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 3);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 5);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 3);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 4);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P405TimeLimit") == 1) {
                    return new StateCheckP405(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP405 : TriggerState {
            internal StateCheckP405(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 2);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 4);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 3);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 5);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 3);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 5);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 5);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 3);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 15);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 15);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 3);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 5);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 3);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 4);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP405(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP405 : TriggerState {
            internal StateNumberOffP405(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{112}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{124}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{134}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{143}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{215}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{223}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{235}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{245}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32010}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32005}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33010}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33005}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{343}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{415}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{425}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{433}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{444}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP405(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP405 : TriggerState {
            internal StateResetP405(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P405End", value: 1);
                context.SetUserValue(key: "G07P405Set", value: 0);
                context.SetUserValue(key: "G07P405TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP406 : TriggerState {
            internal StateNumberOnP406(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{114}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{125}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{133}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{144}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{214}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{222}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23010}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23005}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{242}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{315}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32010}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32005}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{333}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{344}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{415}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{424}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{435}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{445}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 4);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 5);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 3);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 4);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 2);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 15);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 2);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 5);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 15);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 3);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 4);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 5);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 5);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P406TimeLimit") == 1) {
                    return new StateCheckP406(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP406 : TriggerState {
            internal StateCheckP406(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 4);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 5);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 3);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 4);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 2);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 15);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 2);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 5);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 15);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 3);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 4);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 5);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 5);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP406(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP406 : TriggerState {
            internal StateNumberOffP406(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{114}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{125}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{133}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{144}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{214}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{222}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23010}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{23005}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{242}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{315}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32010}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{32005}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{333}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{344}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{415}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{424}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{435}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{445}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP406(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP406 : TriggerState {
            internal StateResetP406(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P406End", value: 1);
                context.SetUserValue(key: "G07P406Set", value: 0);
                context.SetUserValue(key: "G07P406TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNumberOnP407 : TriggerState {
            internal StateNumberOnP407(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7110, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7120, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7130, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7140, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7210, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7220, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7230, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7240, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7310, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7320, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7330, key: "ColorStart", value: 6);
                context.SetUserValue(triggerId: 7340, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7410, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7420, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7430, key: "ColorStart", value: 1);
                context.SetUserValue(triggerId: 7440, key: "ColorStart", value: 1);
                context.PlaySystemSoundInBox(boxIds: new int[]{9000}, sound: "DDStop_Stage_Number_01");
                context.SetMesh(triggerIds: new int[]{113}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{124}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{135}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{144}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{213}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22000}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{234}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{243}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{314}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{325}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33020}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33000}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{342}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{412}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{424}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{435}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{442}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetUserValue(triggerId: 8110, key: "Barrier11", value: 3);
                context.SetUserValue(triggerId: 8120, key: "Barrier12", value: 4);
                context.SetUserValue(triggerId: 8130, key: "Barrier13", value: 5);
                context.SetUserValue(triggerId: 8140, key: "Barrier14", value: 4);
                context.SetUserValue(triggerId: 8210, key: "Barrier21", value: 3);
                context.SetUserValue(triggerId: 8220, key: "Barrier22", value: 20);
                context.SetUserValue(triggerId: 8230, key: "Barrier23", value: 4);
                context.SetUserValue(triggerId: 8240, key: "Barrier24", value: 3);
                context.SetUserValue(triggerId: 8310, key: "Barrier31", value: 4);
                context.SetUserValue(triggerId: 8320, key: "Barrier32", value: 5);
                context.SetUserValue(triggerId: 8330, key: "Barrier33", value: 20);
                context.SetUserValue(triggerId: 8340, key: "Barrier34", value: 2);
                context.SetUserValue(triggerId: 8410, key: "Barrier41", value: 2);
                context.SetUserValue(triggerId: 8420, key: "Barrier42", value: 4);
                context.SetUserValue(triggerId: 8430, key: "Barrier43", value: 5);
                context.SetUserValue(triggerId: 8440, key: "Barrier44", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "G07P407TimeLimit") == 1) {
                    return new StateCheckP407(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckP407 : TriggerState {
            internal StateCheckP407(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9110, key: "Box11Check", value: 3);
                context.SetUserValue(triggerId: 9120, key: "Box12Check", value: 4);
                context.SetUserValue(triggerId: 9130, key: "Box13Check", value: 5);
                context.SetUserValue(triggerId: 9140, key: "Box14Check", value: 4);
                context.SetUserValue(triggerId: 9210, key: "Box21Check", value: 3);
                context.SetUserValue(triggerId: 9220, key: "Box22Check", value: 20);
                context.SetUserValue(triggerId: 9230, key: "Box23Check", value: 4);
                context.SetUserValue(triggerId: 9240, key: "Box24Check", value: 3);
                context.SetUserValue(triggerId: 9310, key: "Box31Check", value: 4);
                context.SetUserValue(triggerId: 9320, key: "Box32Check", value: 5);
                context.SetUserValue(triggerId: 9330, key: "Box33Check", value: 20);
                context.SetUserValue(triggerId: 9340, key: "Box34Check", value: 2);
                context.SetUserValue(triggerId: 9410, key: "Box41Check", value: 2);
                context.SetUserValue(triggerId: 9420, key: "Box42Check", value: 4);
                context.SetUserValue(triggerId: 9430, key: "Box43Check", value: 5);
                context.SetUserValue(triggerId: 9440, key: "Box44Check", value: 2);
            }

            public override TriggerState? Execute() {
                return new StateNumberOffP407(context);
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP407 : TriggerState {
            internal StateNumberOffP407(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new int[]{113}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{124}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{135}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{144}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{213}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{22000}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{234}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{243}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{314}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{325}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33020}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{33000}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{342}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{412}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{424}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{435}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new int[]{442}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                return new StateResetP407(context);
            }

            public override void OnExit() { }
        }

        private class StateResetP407 : TriggerState {
            internal StateResetP407(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "G07P407End", value: 1);
                context.SetUserValue(key: "G07P407Set", value: 0);
                context.SetUserValue(key: "G07P407TimeLimit", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
