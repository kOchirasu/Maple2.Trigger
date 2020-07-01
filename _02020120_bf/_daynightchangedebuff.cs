using System.Numerics;

namespace Maple2.Trigger._02020120_bf {
    public static class _daynightchangedebuff {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {2222}, arg2: true);
                context.SetSkill(arg1: new[] {1212}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 199) == 1) {
                    context.State = new State낮밤변환신호대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State낮밤변환신호대기 : TriggerState {
            internal State낮밤변환신호대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "DayNightChange") == 1) {
                    context.State = new State낮시간으로변화대기단계(context);
                    return;
                }

                if (context.GetUserValue(key: "DayNightChange") == 2) {
                    context.State = new State밤시간으로변화대기단계(context);
                    return;
                }

                if (context.GetUserValue(key: "DayNightChange") == 3) {
                    context.State = new State디버프모조리제거(context);
                    return;
                }

                if (context.GetUserValue(key: "DungeonReset") == 1) {
                    context.State = new State낮시간으로변화하기_맵초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State낮시간으로변화대기단계 : TriggerState {
            internal State낮시간으로변화대기단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1400)) {
                    context.State = new State낮시간으로변화하기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State낮시간으로변화하기 : TriggerState {
            internal State낮시간으로변화하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeBackground(dds: "BG_RedLapenta_A.dds");
                context.SetAmbientLight(arg1: new Vector3(226f, 197f, 211f));
                context.SetDirectionalLight(arg1: new Vector3(224f, 246f, 249f), arg2: new Vector3(170f, 170f, 170f));
                context.SetSkill(arg1: new[] {2222}, arg2: true);
                context.SetSkill(arg1: new[] {1212}, arg2: false);
                context.SetUserValue(key: "DayNightChange", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State낮밤변환신호대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State낮시간으로변화하기_맵초기화 : TriggerState {
            internal State낮시간으로변화하기_맵초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {299}, arg2: 50004547, arg3: 2, arg4: false);
                context.SetUserValue(key: "DungeonReset", value: 0);
                context.SetUserValue(key: "DayNightChange", value: 0);
                context.ChangeBackground(dds: "BG_RedLapenta_A.dds");
                context.SetAmbientLight(arg1: new Vector3(226f, 197f, 211f));
                context.SetDirectionalLight(arg1: new Vector3(224f, 246f, 249f), arg2: new Vector3(170f, 170f, 170f));
                context.SetSkill(arg1: new[] {2222}, arg2: true);
                context.SetSkill(arg1: new[] {1212}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State낮밤변환신호대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State밤시간으로변화대기단계 : TriggerState {
            internal State밤시간으로변화대기단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1400)) {
                    context.State = new State밤시간으로변화하기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State밤시간으로변화하기 : TriggerState {
            internal State밤시간으로변화하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeBackground(dds: "BG_RedLapenta_B.dds");
                context.SetAmbientLight(arg1: new Vector3(120f, 119f, 183f));
                context.SetDirectionalLight(arg1: new Vector3(193f, 100f, 119f), arg2: new Vector3(170f, 170f, 170f));
                context.SetSkill(arg1: new[] {2222}, arg2: false);
                context.SetSkill(arg1: new[] {1212}, arg2: true);
                context.SetUserValue(key: "DayNightChange", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State낮밤변환신호대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State디버프모조리제거 : TriggerState {
            internal State디버프모조리제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {299}, arg2: 50005315, arg3: 1, arg4: false);
                context.SetUserValue(key: "DayNightChange", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1100)) {
                    context.State = new State낮밤변환신호대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}