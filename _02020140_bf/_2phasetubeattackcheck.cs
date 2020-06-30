using System;

namespace Maple2.Trigger._02020140_bf {
    public static class _2phasetubeattackcheck {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "2PhaseTubeStep", value: 0);
                context.SetUserValue(key: "MarbleTurkaSupportMany", value: 0);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new State트리거작동신호받기대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거작동신호받기대기중 : TriggerState {
            internal State트리거작동신호받기대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "2PhaseTubeStep", value: 1, @operator: "GreaterEqual")) {
                    context.State = new State트리거작동대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거작동대기중 : TriggerState {
            internal State트리거작동대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State트리거작동시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트리거작동시작 : TriggerState {
            internal State트리거작동시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "2PhaseTubeStep", value: 1)) {
                    context.State = new State튜브대미지필드_1단계진행(context);
                    return;
                }

                if (context.UserValue(key: "2PhaseTubeStep", value: 2)) {
                    context.State = new State튜브대미지필드_2단계전환_우선1단계제거(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State튜브대미지필드_1단계진행 : TriggerState {
            internal State튜브대미지필드_1단계진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "MarbleTurkaSupportMany", value: 1, @operator: "GreaterEqual")) {
                    context.State = new State1단계_튜브대미지필드_생성(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1단계_튜브대미지필드_제거(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1단계_튜브대미지필드_생성 : TriggerState {
            internal State1단계_튜브대미지필드_생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {102}, arg2: 50004566, arg3: 1, arg4: true, arg5: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "2PhaseTubeStep", value: 2)) {
                    context.State = new State튜브대미지필드_2단계전환_우선1단계제거(context);
                    return;
                }

                if (context.UserValue(key: "MarbleTurkaSupportMany", value: 0)) {
                    context.State = new State1단계_튜브대미지필드_제거(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1단계_튜브대미지필드_제거 : TriggerState {
            internal State1단계_튜브대미지필드_제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcRemoveAdditionalEffect(spawnPointID: 102, additionalEffectID: 50004566);
            }

            public override void Execute() {
                if (context.UserValue(key: "2PhaseTubeStep", value: 2)) {
                    context.State = new State튜브대미지필드_2단계전환_우선1단계제거(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State튜브대미지필드_1단계진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State튜브대미지필드_2단계전환_우선1단계제거 : TriggerState {
            internal State튜브대미지필드_2단계전환_우선1단계제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcRemoveAdditionalEffect(spawnPointID: 102, additionalEffectID: 50004566);
                context.SetUserValue(key: "TubeLeveStep", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State2단계_튜브대미지필드_처음단계(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2단계_튜브대미지필드_처음단계 : TriggerState {
            internal State2단계_튜브대미지필드_처음단계(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "MarbleTurkaSupportMany", value: 1, @operator: "GreaterEqual")) {
                    context.State = new State2단계_튜브대미지필드_1Lv생성(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2단계_튜브대미지필드_제거(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2단계_튜브대미지필드_1Lv생성 : TriggerState {
            internal State2단계_튜브대미지필드_1Lv생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {102}, arg2: 50004563, arg3: 1, arg4: true, arg5: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2단계_튜브대미지필드_TubeLeveStep_더하기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2단계_튜브대미지필드_2Lv생성 : TriggerState {
            internal State2단계_튜브대미지필드_2Lv생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcRemoveAdditionalEffect(spawnPointID: 102, additionalEffectID: 50004563);
                context.AddBuff(arg1: new int[] {102}, arg2: 50004564, arg3: 1, arg4: true, arg5: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2단계_튜브대미지필드_TubeLeveStep_더하기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2단계_튜브대미지필드_3Lv생성 : TriggerState {
            internal State2단계_튜브대미지필드_3Lv생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcRemoveAdditionalEffect(spawnPointID: 102, additionalEffectID: 50004564);
                context.AddBuff(arg1: new int[] {102}, arg2: 50004565, arg3: 1, arg4: true, arg5: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2단계_튜브대미지필드_TubeLeveStep_더하기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2단계_튜브대미지필드_TubeLeveStep_더하기 : TriggerState {
            internal State2단계_튜브대미지필드_TubeLeveStep_더하기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddUserValue(key: "TubeLeveStep", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2단계_튜브대미지필드_TubeLeveStep_체크(context);
                    return;
                }

                if (context.UserValue(key: "TubeLeveStep", value: 30)) {
                    context.State = new State버프부여구슬제거경고메시지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2단계_튜브대미지필드_TubeLeveStep_체크 : TriggerState {
            internal State2단계_튜브대미지필드_TubeLeveStep_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "TubeLeveStep", value: 10)) {
                    context.State = new State2단계_튜브대미지필드_2Lv생성(context);
                    return;
                }

                if (context.UserValue(key: "TubeLeveStep", value: 20)) {
                    context.State = new State2단계_튜브대미지필드_3Lv생성(context);
                    return;
                }

                if (context.UserValue(key: "MarbleTurkaSupportMany", value: 1, @operator: "GreaterEqual")) {
                    context.State = new State2단계_튜브대미지필드_TubeLeveStep_더하기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2단계_튜브대미지필드_제거(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프부여구슬제거경고메시지 : TriggerState {
            internal State버프부여구슬제거경고메시지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddUserValue(key: "TubeLeveStep", value: -9);
                context.AddBuff(arg1: new int[] {102}, arg2: 50000348, arg3: 2, arg4: true, arg5: true);
                context.ShowGuideSummary(entityID: 29200005, textID: 29200005, durationTime: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2단계_튜브대미지필드_TubeLeveStep_체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2단계_튜브대미지필드_제거 : TriggerState {
            internal State2단계_튜브대미지필드_제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcRemoveAdditionalEffect(spawnPointID: 102, additionalEffectID: 50004563);
                context.NpcRemoveAdditionalEffect(spawnPointID: 102, additionalEffectID: 50004564);
                context.NpcRemoveAdditionalEffect(spawnPointID: 102, additionalEffectID: 50004565);
                context.NpcRemoveAdditionalEffect(spawnPointID: 102, additionalEffectID: 50000348);
                context.SetUserValue(key: "TubeLeveStep", value: 0);
                context.HideGuideSummary(entityID: 29200005);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2단계_튜브대미지필드_처음단계(context);
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