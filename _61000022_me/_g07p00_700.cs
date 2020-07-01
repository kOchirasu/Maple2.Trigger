namespace Maple2.Trigger._61000022_me {
    public static class _g07p00_700 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {110, 111, 112, 113, 114, 115}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {120, 121, 122, 123, 124, 125}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {130, 131, 132, 133, 134, 135}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {140, 141, 142, 143, 144, 145}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {210, 211, 212, 213, 214, 215}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {220, 221, 222, 223, 224, 225}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {230, 231, 232, 233, 234, 235}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {240, 241, 242, 243, 244, 245}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {310, 311, 312, 313, 314, 315}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {320, 321, 322, 323, 324, 325}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {330, 331, 332, 333, 334, 335}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {340, 341, 342, 343, 344, 345}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {410, 411, 412, 413, 414, 415}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {420, 421, 422, 423, 424, 425}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {430, 431, 432, 433, 434, 435}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {440, 441, 442, 443, 444, 445}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(arg1: new int[] {2207, 2208, 2209, 22000, 22005, 22010, 22020, 22030}, arg2: false,
                    arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {2307, 2308, 2309, 23000, 23005, 23010, 23020, 23030}, arg2: false,
                    arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3207, 3208, 3209, 32000, 32005, 32010, 32020, 32030}, arg2: false,
                    arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3307, 3308, 3309, 33000, 33005, 33010, 33020, 33030}, arg2: false,
                    arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "G07P201Set") == 1) {
                    context.State = new StateNumberOnP201(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P202Set") == 1) {
                    context.State = new StateNumberOnP202(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P203Set") == 1) {
                    context.State = new StateNumberOnP203(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P204Set") == 1) {
                    context.State = new StateNumberOnP204(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P205Set") == 1) {
                    context.State = new StateNumberOnP205(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P206Set") == 1) {
                    context.State = new StateNumberOnP206(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P207Set") == 1) {
                    context.State = new StateNumberOnP207(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P208Set") == 1) {
                    context.State = new StateNumberOnP208(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P209Set") == 1) {
                    context.State = new StateNumberOnP209(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P210Set") == 1) {
                    context.State = new StateNumberOnP210(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P301Set") == 1) {
                    context.State = new StateNumberOnP301(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P302Set") == 1) {
                    context.State = new StateNumberOnP302(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P303Set") == 1) {
                    context.State = new StateNumberOnP303(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P304Set") == 1) {
                    context.State = new StateNumberOnP304(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P305Set") == 1) {
                    context.State = new StateNumberOnP305(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P306Set") == 1) {
                    context.State = new StateNumberOnP306(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P307Set") == 1) {
                    context.State = new StateNumberOnP307(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P308Set") == 1) {
                    context.State = new StateNumberOnP308(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P309Set") == 1) {
                    context.State = new StateNumberOnP309(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P310Set") == 1) {
                    context.State = new StateNumberOnP310(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P401Set") == 1) {
                    context.State = new StateNumberOnP401(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P402Set") == 1) {
                    context.State = new StateNumberOnP402(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P403Set") == 1) {
                    context.State = new StateNumberOnP403(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P404Set") == 1) {
                    context.State = new StateNumberOnP404(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P405Set") == 1) {
                    context.State = new StateNumberOnP405(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P406Set") == 1) {
                    context.State = new StateNumberOnP406(context);
                    return;
                }

                if (context.GetUserValue(key: "G07P407Set") == 1) {
                    context.State = new StateNumberOnP407(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {120}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22005}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {322}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {430}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {440}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P201TimeLimit") == 1) {
                    context.State = new StateCheckP201(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP201(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP201 : TriggerState {
            internal StateNumberOffP201(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {120}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22005}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {322}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {430}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {440}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP201(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {210}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23005}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {322}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {410}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P202TimeLimit") == 1) {
                    context.State = new StateCheckP202(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP202(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP202 : TriggerState {
            internal StateNumberOffP202(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {210}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23005}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {322}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {410}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP202(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {130}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {210}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {240}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32005}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {430}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P203TimeLimit") == 1) {
                    context.State = new StateCheckP203(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP203(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP203 : TriggerState {
            internal StateNumberOffP203(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {130}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {210}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {240}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32005}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {430}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP203(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {120}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {140}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {240}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33005}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {430}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P204TimeLimit") == 1) {
                    context.State = new StateCheckP204(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP204(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP204 : TriggerState {
            internal StateNumberOffP204(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {120}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {140}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {240}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33005}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {430}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP204(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {120}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {330}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {420}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P205TimeLimit") == 1) {
                    context.State = new StateCheckP205(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP205(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP205 : TriggerState {
            internal StateNumberOffP205(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {120}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {330}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {420}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP205(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {111}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {141}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {310}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {340}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {411}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P206TimeLimit") == 1) {
                    context.State = new StateCheckP206(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP206(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP206 : TriggerState {
            internal StateNumberOffP206(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {111}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {141}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {310}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {340}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {411}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP206(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {210}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {221}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {431}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {440}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P207TimeLimit") == 1) {
                    context.State = new StateCheckP207(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP207(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP207 : TriggerState {
            internal StateNumberOffP207(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {210}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {221}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {431}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {440}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP207(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {121}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {231}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {341}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {441}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P208TimeLimit") == 1) {
                    context.State = new StateCheckP208(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP208(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP208 : TriggerState {
            internal StateNumberOffP208(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {121}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {231}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {324}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {341}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {441}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP208(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22005}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P209TimeLimit") == 1) {
                    context.State = new StateCheckP209(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP209(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP209 : TriggerState {
            internal StateNumberOffP209(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22005}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP209(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {110}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {140}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {210}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {320}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33005}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {440}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P210TimeLimit") == 1) {
                    context.State = new StateCheckP210(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP210(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP210 : TriggerState {
            internal StateNumberOffP210(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {110}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {140}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {210}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {320}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33005}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {440}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP210(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33005}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P301TimeLimit") == 1) {
                    context.State = new StateCheckP301(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP301(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP301 : TriggerState {
            internal StateNumberOffP301(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33005}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP301(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23005}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P302TimeLimit") == 1) {
                    context.State = new StateCheckP302(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP302(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP302 : TriggerState {
            internal StateNumberOffP302(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23005}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP302(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32005}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P303TimeLimit") == 1) {
                    context.State = new StateCheckP303(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP303(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP303 : TriggerState {
            internal StateNumberOffP303(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32005}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP303(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {322}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P304TimeLimit") == 1) {
                    context.State = new StateCheckP304(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP304(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP304 : TriggerState {
            internal StateNumberOffP304(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {233}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {322}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP304(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {211}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {411}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {431}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P305TimeLimit") == 1) {
                    context.State = new StateCheckP305(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP305(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP305 : TriggerState {
            internal StateNumberOffP305(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {211}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {411}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {431}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP305(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {141}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {411}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {441}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P306TimeLimit") == 1) {
                    context.State = new StateCheckP306(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP306(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP306 : TriggerState {
            internal StateNumberOffP306(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {141}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {411}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {441}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP306(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32030}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P307TimeLimit") == 1) {
                    context.State = new StateCheckP307(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP307(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP307 : TriggerState {
            internal StateNumberOffP307(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32030}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {414}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP307(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23030}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {311}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {332}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {431}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P308TimeLimit") == 1) {
                    context.State = new StateCheckP308(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP308(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP308 : TriggerState {
            internal StateNumberOffP308(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {131}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23030}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {311}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {332}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {431}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP308(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22005}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33005}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P309TimeLimit") == 1) {
                    context.State = new StateCheckP309(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP309(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP309 : TriggerState {
            internal StateNumberOffP309(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22005}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33005}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP309(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P310TimeLimit") == 1) {
                    context.State = new StateCheckP310(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP310(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP310 : TriggerState {
            internal StateNumberOffP310(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {123}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {142}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP310(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22030}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {432}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P401TimeLimit") == 1) {
                    context.State = new StateCheckP401(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP401(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP401 : TriggerState {
            internal StateNumberOffP401(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {122}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22030}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {244}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {323}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {334}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {413}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {432}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP401(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33030}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P402TimeLimit") == 1) {
                    context.State = new StateCheckP402(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP402(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP402 : TriggerState {
            internal StateNumberOffP402(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {224}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33030}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {434}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP402(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23005}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P403TimeLimit") == 1) {
                    context.State = new StateCheckP403(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP403(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP403 : TriggerState {
            internal StateNumberOffP403(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {212}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {225}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23005}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {335}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {423}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP403(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {115}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32005}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P404TimeLimit") == 1) {
                    context.State = new StateCheckP404(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP404(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP404 : TriggerState {
            internal StateNumberOffP404(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {115}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {132}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {145}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {232}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32005}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {345}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {422}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {443}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP404(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {112}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32005}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33005}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P405TimeLimit") == 1) {
                    context.State = new StateCheckP405(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP405(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP405 : TriggerState {
            internal StateNumberOffP405(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {112}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {134}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {143}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {215}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {223}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {235}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {245}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {313}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32005}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33005}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {343}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {425}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {433}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {444}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP405(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {114}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23005}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32010}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32005}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P406TimeLimit") == 1) {
                    context.State = new StateCheckP406(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP406(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP406 : TriggerState {
            internal StateNumberOffP406(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {114}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {125}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {133}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {214}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {222}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {23005}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {242}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {315}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32010}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {32005}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {333}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {344}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {415}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {445}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP406(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
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
                context.PlaySystemSoundInBox(arg1: new int[] {9000}, arg2: "DDStop_Stage_Number_01");
                context.SetMesh(arg1: new int[] {113}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33020}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33000}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
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

            public override void Execute() {
                if (context.GetUserValue(key: "G07P407TimeLimit") == 1) {
                    context.State = new StateCheckP407(context);
                    return;
                }
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

            public override void Execute() {
                if (true) {
                    context.State = new StateNumberOffP407(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNumberOffP407 : TriggerState {
            internal StateNumberOffP407(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {113}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {124}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {135}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {144}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {213}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {22000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {234}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {243}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {325}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33020}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {33000}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {342}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {412}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {424}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {435}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {442}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateResetP407(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}