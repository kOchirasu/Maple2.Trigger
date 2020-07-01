using System.Numerics;

namespace Maple2.Trigger._02020111_bf {
    public static class _lapenta_attack_guide {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200001, 200002, 200003, 200004, 200005, 200011, 200012, 200013, 200014, 200015, 200021, 200022, 200023, 200024, 200025, 200031, 200032, 200033, 200034, 200035}, arg2: false);
                context.SetAmbientLight(arg1: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(arg1: new Vector3(192f, 210f, 211f), arg2: new Vector3(170f, 170f, 170f));
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Lapenta_Attack_Guide") == 1) {
                    return new State어둠효과_페이드아웃(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어둠효과_페이드아웃 : TriggerState {
            internal State어둠효과_페이드아웃(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddBuff(arg1: new[] {1001}, arg2: 75000001, arg3: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetAmbientLight(arg1: new Vector3(52f, 48f, 38f));
                    context.SetDirectionalLight(arg1: new Vector3(0f, 0f, 0f), arg2: new Vector3(206f, 174f, 84f));
                    return new State가이드발동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가이드발동 : TriggerState {
            internal State가이드발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200001, 200002, 200003, 200004, 200005, 200011, 200012, 200013, 200014, 200015, 200021, 200022, 200023, 200024, 200025, 200031, 200032, 200033, 200034, 200035}, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddBuff(arg1: new[] {1001}, arg2: 75000001, arg3: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Lapenta_Attack_Guide") == 0) {
                    return new State가이드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가이드종료 : TriggerState {
            internal State가이드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200001, 200002, 200003, 200004, 200005, 200011, 200012, 200013, 200014, 200015, 200021, 200022, 200023, 200024, 200025, 200031, 200032, 200033, 200034, 200035}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Lapenta_Attack_Guide") == 2) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}